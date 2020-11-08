using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageUpdate {

    //ブロック配列に入れる
    public void BlockSave(GameObject block)
    {
        var pos = block.transform.position;
        block.transform.position = new Vector3(pos.x, Convert.ToInt32(pos.y), pos.z);
        foreach (Transform child in block.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x);
            int PosY = Convert.ToInt32(child.transform.position.y);
            int PosZ = Convert.ToInt32(child.transform.position.z);
            //リスト更新
            StageManeger.Instance.stage[PosX, PosY, PosZ] = 2;
            //削除用
            StageManeger.Instance.destoryBlocks[PosX, PosY, PosZ] = child.gameObject;
        }
    }

}
