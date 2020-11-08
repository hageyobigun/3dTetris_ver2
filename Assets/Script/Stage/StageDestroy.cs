using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageDestroy : MonoBehaviour {

    public static GameObject[,,] DestoryBlocks;
    public int destoryRange;
    public bool canDestory = false;


    //削除するかどうか
    public  void destroyCheck()
    {

        int[] destroyLine = new int[15];
        int count = 0;
        for (int y = 1; y < 15; y++)
        {
            for (int x = destoryRange + 1; x < destoryRange * 2; x++)
            {
                for (int z = destoryRange + 1; z < destoryRange * 2; z++)
                {
                    if (Block.stage[x, y, z] == 2)
                    {
                        count++;
                    }
                }
            }
            if (count == (destoryRange - 1) * (destoryRange - 1))
            {
                destroyLine[y] = 1;
                canDestory = true;
            }
            count = 0;
        }
        if (canDestory == true)
        {
            BlockDestory(destroyLine);
            canDestory = false;
        }
    }

    //削除
    public  void BlockDestory(int[] Line)
    {
        for (int y = 14; y > 0; y--)
        {
            if (Line[y] == 1)
            {
                for (int x = destoryRange + 1; x < 2 * destoryRange; x++)
                {
                    for (int z = destoryRange + 1; z < 2 * destoryRange; z++)
                    {
                        Destroy(DestoryBlocks[x, y, z].gameObject);
                    }
                }
            }
        }

    }

}
