using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation {

    //回転して壁に当たったりしないか
    public bool IsRotation(GameObject block)
    {
        foreach (Transform child in block.transform)
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

    //回転
    public void Rotation(GameObject block, Vector3 Angle)
    {
        block.transform.Rotate(Vector3.up, Angle.y, Space.World);
        block.transform.Rotate(Vector3.right, Angle.x, Space.World);
        block.transform.Rotate(Vector3.forward, Angle.z, Space.World);
        //戻す
        if (IsRotation(block) == false)
        {
            block.transform.Rotate(Vector3.up, Angle.y * -1, Space.World);
            block.transform.Rotate(Vector3.right, Angle.x * -1, Space.World);
            block.transform.Rotate(Vector3.forward, Angle.z * -1, Space.World);
        }
    }
}
