using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageInstance : MonoBehaviour {

    //[SerializeField] private Transform stagePlace;
    [SerializeField] private GameObject stageBlock;

    //ステージ生成
    public void Stage(int StageSize)
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
                        StageManeger.Instance.stage[x, y, z] = 1;
                        Instantiate(stageBlock, new Vector3(x, y, z), Quaternion.identity);
                        //stages.transform.SetParent(stagePlace, false);

                    }
                    //置いてくブロックは
                    else if (y == 0)
                    {
                        StageManeger.Instance.stage[x, y, z] = 2;
                        Instantiate(stageBlock, new Vector3(x, y, z), Quaternion.identity);
                        //stages.transform.SetParent(stagePlace, false);
                    }
                    //それ以外は０
                    else
                    {
                        StageManeger.Instance.stage[x, y, z] = 0;
                    }
                }
            }
        }

    }
}
