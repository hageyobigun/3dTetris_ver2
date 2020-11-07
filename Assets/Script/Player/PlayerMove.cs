using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMove{


    //移動可能か
    public bool IsMove(int x, int z)
    {
        foreach (Transform child in Player.players.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x) + x;
            int PosY = Convert.ToInt32(child.transform.position.y);
            int PosZ = Convert.ToInt32(child.transform.position.z) + z;
            if (StageManeger.Instance.stage[PosX, PosY, PosZ] == 1 || StageManeger.Instance.stage[PosX, PosY, PosZ] == 2)
            {
                return false;
            }
        }
        return true;
    }

    //移動
    void BlockMove(GameObject player)
    {

    }
}
