using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageDestroy : MonoBehaviour{

    private int destorySize;

    //削除
    public void BlockDestory(int stageSize)
    {
        destorySize = stageSize;
        for (int y = 14; y > 0; y--)
        {
            if (StageManeger.Instance.blockCount[y] == (destorySize - 1) * (destorySize - 1))
            {
                for (int x = destorySize + 1; x < destorySize * 2; x++)
                {
                    for (int z = destorySize + 1; z < destorySize * 2; z++)
                    {
                        Destroy(StageManeger.Instance.destoryBlocks[x, y, z].gameObject);
                        StageManeger.Instance.blockCount[y] = 0;
                    }
                }
                DownLine(y);
                StageManeger.Instance.scoreValue += 100;//スコア100
            }
        }

    }

    //削除後下に下げる
    public void DownLine(int line)
    {
        for (int y = line; y < 15; y++)
        {
            for (int x = destorySize + 1; x < destorySize * 2; x++)
            {
                for (int z = destorySize + 1; z < destorySize * 2; z++)
                {
                    if (StageManeger.Instance.destoryBlocks[x, y + 1, z] != null)
                    {
                        //一段下げる
                        StageManeger.Instance.destoryBlocks[x, y + 1, z].transform.position += new Vector3(0, -1, 0);
                        StageManeger.Instance.destoryBlocks[x, y, z] = StageManeger.Instance.destoryBlocks[x, y + 1, z];
                        StageManeger.Instance.destoryBlocks[x, y + 1, z] = null;
                    }
                    StageManeger.Instance.stage[x, y, z] = StageManeger.Instance.stage[x, y + 1, z];
                }
            }

        }
    }

}
