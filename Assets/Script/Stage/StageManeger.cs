using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class StageManeger : SingletonMonoBehaviour<StageManeger>
{
    public int[,,] stage;　//ステージの情報を入れとくもの
    public GameObject[,,] destoryBlocks;　//消去するブロックを入れておくもの
    public int[] blockCount; //ブロックの数を入れておくもの

    public int StageSize; //ステージの大きさ
    public int PlayerPos; //ブロックの生成位置
    public int scoreValue;

    private StageUpdate stageUpdate;
    private StageDestroy stageDestroy;
    private StageCount stageCount;
    private StageInstance stageInstance;
    private GameOver gameOver;

    public Subject<GameObject> updateStageSubject = new Subject<GameObject>(); //ブロックが置かれた処理をまとめたもの

    private void Start()
    {
        updateStageSubject.Subscribe(block =>
        {
            scoreValue += 2;//ブロック置いたら＋２（
            stageUpdate.BlockSave(block);
            stageCount.BlockCount();
            stageDestroy.BlockDestory(StageSize);
            gameOver.CheckGameOver();
        });

    }
    //初期化
    public void Initialize()
    {
        StageSize = GameManeger.Instance.stagesize + 1; //壁の分もあるので+1
        PlayerPos = StageSize + StageSize / 2; //真ん中あたりになるように
        destoryBlocks = new GameObject[100, 100, 100];
        stage = new int[36, 36, 36];
        scoreValue = 0;

        stageUpdate = new StageUpdate();
        stageCount = new StageCount();
        stageDestroy = GetComponent<StageDestroy>();
        stageInstance = GetComponent<StageInstance>();
        gameOver = new GameOver();
        stageInstance.Stage(StageSize);
    }
}
