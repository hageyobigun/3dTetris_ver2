using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMove{

    //移動可能か
    public bool IsMove(GameObject block, Vector3 movePosition)
    {

        foreach (Transform child in block.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x + movePosition.x);
            int PosY = Convert.ToInt32(child.transform.position.y);
            int PosZ = Convert.ToInt32(child.transform.position.z + movePosition.z);
            if (StageManeger.Instance.stage[PosX, PosY, PosZ] == 1 || StageManeger.Instance.stage[PosX, PosY, PosZ] == 2)
            {
                return false;
            }
        }
        return true;
    }

    //移動
    public void BlockMove(GameObject block, Vector3 movePosition)
    {
        if (IsMove(block, movePosition))
        {
            var target = block.transform.position + movePosition;
            block.transform.position = Vector3.MoveTowards(block.transform.position, target, 2.0f);
        }
    }
}
