using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPut {

    //落下完了したか
    public bool IsPut()
    {
        foreach (Transform child in Player.players.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x);
            int PosY = Convert.ToInt32(child.transform.position.y) - 1;
            int PosZ = Convert.ToInt32(child.transform.position.z);
            if (StageManeger.Instance.stage[PosX, PosY, PosZ] == 2)
            {
                return true;
            }
        }
        return false;
    }
}
