using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageUpdate {

    //ブロック配列に入れる
    public void BlockSave()
    {
        var pos = Player.players.transform.position;
        Player.players.transform.position = new Vector3(pos.x, Convert.ToInt32(pos.y), pos.z);
        foreach (Transform child in Player.players.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x);
            int PosY = Convert.ToInt32(child.transform.position.y);
            int PosZ = Convert.ToInt32(child.transform.position.z);
            //リスト更新
            StageManeger.Instance.stage[PosX, PosY, PosZ] = 2;
            //削除用
            StageManeger.Instance.DestoryBlocks[PosX, PosY, PosZ] = child.gameObject;
        }
    }

}
