using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation {

    //回転
    public static bool IsRotation()
    {
        foreach (Transform child in Player.players.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x);
            int PosY = Convert.ToInt32(child.transform.position.y);
            int PosZ = Convert.ToInt32(child.transform.position.z);

            if (StageManeger.Instance.stage[PosX, PosY, PosZ] == 1 || StageManeger.Instance.stage[PosX, PosY, PosZ] == 2)
            {
                return false;
            }
        }
        return true;
    }


    public void Rotation(Vector3 v, GameObject player)
    {
        player.transform.Rotate(Vector3.up, v.y, Space.World);
        player.transform.Rotate(Vector3.right, v.x, Space.World);
        player.transform.Rotate(Vector3.forward, v.z, Space.World);
    }
}
