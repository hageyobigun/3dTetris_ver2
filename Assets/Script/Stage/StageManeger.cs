using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class StageManeger : SingletonMonoBehaviour<StageManeger>
{

    public GameObject stageBlock;
    public int[,,] stage = new int[36, 36, 36];
    public int StageSize;
    public int PlayerPos;

    [SerializeField] private Transform stagePlace;
    public GameObject[,,] DestoryBlocks = new GameObject[100, 100, 100];

    // Use this for initialization
    void Start()
    {
        StageSize = StageSize + 1;
        PlayerPos = StageSize + StageSize / 2;
        StageInstance();
    }

    //ステージ生成
    void StageInstance()
    {

        for (int x = StageSize; x < StageSize * 2 + 1; x++)
        {
            for (int y = 0; y < 25; y++)
            {
                for (int z = StageSize; z < StageSize * 2 + 1; z++)
                {
                    //壁は1
                    if (x == StageSize || x == 2 * StageSize || z == StageSize || z == 2 * StageSize)
                    {
                        stage[x, y, z] = 1;
                        GameObject stages = Instantiate(stageBlock, new Vector3(x, y, z), Quaternion.identity);
                        stages.transform.SetParent(stagePlace, false);

                    }
                    //置いてくブロックは
                    else if (y == 0)
                    {
                        stage[x, y, z] = 2;
                        GameObject stages = Instantiate(stageBlock, new Vector3(x, y, z), Quaternion.identity);
                        stages.transform.SetParent(stagePlace, false);
                    }
                    //それ以外は０
                    else
                    {
                        stage[x, y, z] = 0;
                    }
                }
            }
        }

    }

}
