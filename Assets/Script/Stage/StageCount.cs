using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCount{

    private int[] Count;

    void onBlockCount()
    {
        Count = new int[15];
        for (int y = 1; y < 15; y++)
        {
            for (int x = Block.StageSize; x < Block.StageSize * 2 + 1; x++)
            {
                for (int z = Block.StageSize; z < Block.StageSize * 2 + 1; z++)
                {
                    if (Block.stage[x, y, z] == 2)
                    {
                        Count[y]++;
                    }
                }
            }
        }
    }
}
