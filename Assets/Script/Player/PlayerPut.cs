using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPut {

    //落下完了したか
    public bool IsPut(GameObject block)
    {
        foreach (Transform child in block.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x);
            int PosY = Convert.ToInt32(child.transform.position.y) - 1;
            int PosZ = Convert.ToInt32(child.transform.position.z);
            if (StageManeger.Instance.stage[PosX, PosY, PosZ] == 2)
            {
                var pos = block.transform.position;
                block.transform.position = new Vector3(pos.x, Convert.ToInt32(pos.y), pos.z);
                StageManeger.Instance.updateStageSubject.OnNext(block);
                return true;
            }
        }
        return false;
    }
}
