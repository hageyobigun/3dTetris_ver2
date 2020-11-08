using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class StageManeger : SingletonMonoBehaviour<StageManeger>
{
    public int[,,] stage;
    public GameObject[,,] destoryBlocks;
    public int[] blockCount;

    public int StageSize;
    public int PlayerPos;

    private StageUpdate stageUpdate;
    private StageDestroy stageDestroy;
    private StageCount stageCount;
    private StageInstance stageInstance;

    public Subject<GameObject> updateStageSubject = new Subject<GameObject>();

    [SerializeField] private GameObject mainCamera;

    private void Start()
    {
        Initialize();

        updateStageSubject.Subscribe(block =>
        {
            stageUpdate.BlockSave(block);
            stageCount.BlockCount();
            stageDestroy.BlockDestory(StageSize);
        });

    }
    private void Initialize()
    {
        StageSize = StageSize + 1;
        PlayerPos = StageSize + StageSize / 2;
        mainCamera.transform.position = new Vector3(PlayerPos, 25f, PlayerPos);
        destoryBlocks = new GameObject[100, 100, 100];
        stage = new int[36, 36, 36];

        stageUpdate = new StageUpdate();
        stageCount = new StageCount();
        stageDestroy = GetComponent<StageDestroy>();
        stageInstance = GetComponent<StageInstance>();
        stageInstance.Stage(StageSize);
    }
}
