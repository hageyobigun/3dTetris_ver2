using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayBlockManeger : MonoBehaviour {

    public  static int[,,] stageCopy;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        

	}
    //移動可能か
    public  static bool MoveCheck(int x,int z)
    {
        stageCopy = Block.stage;
        foreach (Transform child in Player.players.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x) + x;
            int PosY = Convert.ToInt32(child.transform.position.y);
            int PosZ = Convert.ToInt32(child.transform.position.z) + z;
            if (stageCopy[PosX, PosY, PosZ] ==  1 || stageCopy[PosX, PosY, PosZ] == 2)
            {
                return false;
            }
        }
        return true;
    }

    //落下完了したか
    public static bool BlockFall()
    {
        stageCopy = Block.stage;
        foreach (Transform child in Player.players.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x);
            int PosY = Convert.ToInt32(child.transform.position.y) -1;
            int PosZ = Convert.ToInt32(child.transform.position.z);
            if (stageCopy[PosX, PosY, PosZ] == 2)
            {
                BlockSave();
                return true;
            }
        }
        return false;
    }

    //回転
    public static bool RotationPos()
    {
        stageCopy = Block.stage;
        foreach (Transform child in Player.players.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x);
            int PosY = Convert.ToInt32(child.transform.position.y);
            int PosZ = Convert.ToInt32(child.transform.position.z);

            if (stageCopy[PosX, PosY, PosZ] == 1 || stageCopy[PosX, PosY, PosZ] == 2)
            {
                return false;
            }
        }
        return true;
    }


    //ブロック配列に入れる
    public static void BlockSave(){
        stageCopy = Block.stage;
        Vector3 pos;
        pos = Player.players.transform.position;
        Player.players.transform.position = new Vector3(pos.x, Convert.ToInt32(pos.y) , pos.z);
        foreach (Transform child in Player.players.transform)
        {
            int RotPosX = Convert.ToInt32(child.transform.position.x);
            int RotPosY = Convert.ToInt32(child.transform.position.y);
            int RotPosZ = Convert.ToInt32(child.transform.position.z);
            stageCopy[RotPosX, RotPosY, RotPosZ] = 2;
        }
        Block.stage = stageCopy;

    }



}