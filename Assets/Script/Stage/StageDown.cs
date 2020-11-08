using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDown{

    public int destoryRange;

    //削除後
    public void AfterDestoy(int line)
    {
        for (int y = line; y < 15; y++)
        {
            for (int x = destoryRange + 1; x < destoryRange * 2; x++)
            {
                for (int z = destoryRange + 1; z < destoryRange * 2; z++)
                {
                    if (StageManeger.Instance.DestoryBlocks[x, y + 1, z] != null)
                    {
                        //一段下げる
                        StageManeger.Instance.DestoryBlocks[x, y + 1, z].transform.position += new Vector3(0, -1, 0);
                        StageManeger.Instance.DestoryBlocks[x, y, z] = StageManeger.Instance.DestoryBlocks[x, y + 1, z];
                        StageManeger.Instance.DestoryBlocks[x, y + 1, z] = null;
                    }
                    StageManeger.Instance.stage[x, y, z] = StageManeger.Instance.stage[x, y + 1, z];
                }
            }

        }
    }
}
