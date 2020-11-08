using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCount{

    public void BlockCount()
    {
        var size = StageManeger.Instance.StageSize;
        StageManeger.Instance.blockCount = new int[20];
        for (int y = 1; y < 15; y++)
        {
            for (int x = size; x < size * 2; x++)
            {
                for (int z = size; z < size * 2; z++)
                {
                    if (StageManeger.Instance.stage[x, y, z] == 2)
                    {
                        StageManeger.Instance.blockCount[y]++;
                    }
                }
            }
        }
    }
}
