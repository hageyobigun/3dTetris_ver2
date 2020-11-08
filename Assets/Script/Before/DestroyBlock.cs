using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DestroyBlock : MonoBehaviour {

    public static GameObject[,,] DestoryBlocks;
    public static int destoryRange;
    public static bool canDestory = false;

    public static AudioSource DestroySound; 
    public  AudioSource DestroySounyCopy; 

	// Use this for initialization
	void Start () {

        DestroySounyCopy.Stop();
        DestroySound = DestroySounyCopy;
        DestoryBlocks = new GameObject[100,100,100];
        DestroySound.Stop();
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    //列ごとに入れる
    public static void InDestoryList()
    {
        destoryRange = Block.StageSizeCopy;
        foreach (Transform child in Player.players.transform)
        {
            int PosX = Convert.ToInt32(child.transform.position.x);
            int PosY = Convert.ToInt32(child.transform.position.y);
            int PosZ = Convert.ToInt32(child.transform.position.z);
            DestoryBlocks[PosX, PosY, PosZ] = child.gameObject;
        }
    }

    //削除するかどうか
    public static void destroyCheck()
    {

        int [] destroyLine = new int[15];
        int count = 0;
        for (int y = 1; y < 15; y++)
        {
            for (int x = destoryRange + 1; x < destoryRange * 2; x++)
            {
                for (int z = destoryRange + 1; z < destoryRange * 2; z++)
                {
                    if (Block.stage[x, y, z] == 2)
                    {
                        count++;
                    }
                }
            }
            if (count == (destoryRange-1) * (destoryRange-1))
            {
                destroyLine[y] = 1;
                canDestory = true;
            }
            count = 0;
        }
        if (canDestory == true)
        {
            BlockDestory(destroyLine);
            canDestory = false;
        }
    }
    //削除
    public static void BlockDestory(int [] Line)
    {
        DestroySound.Play();
        for (int y = 14; y > 0; y--)
        {
            if (Line[y] == 1)
            {
                for (int x = destoryRange + 1; x < 2*destoryRange; x++)
                {
                    for (int z = destoryRange + 1; z < 2*destoryRange; z++)
                    {
                        Destroy(DestoryBlocks[x, y, z].gameObject);
                    }
                }
                Score.scoreValue += 100;
                AfterDestoy(y);
            }
        }

    }

    //削除後
    public static void AfterDestoy(int line)
    {
        for (int y = line; y < 15; y++)
        {
            for (int x = destoryRange + 1; x < destoryRange * 2; x++)
            {
                for (int z = destoryRange + 1; z < destoryRange * 2; z++)
                {
                    if (DestoryBlocks[x, y + 1, z] != null)
                    {   
                        //一段下げる
                        DestoryBlocks[x, y + 1, z].transform.position += new Vector3(0, -1, 0);
                        DestoryBlocks[x, y, z] = DestoryBlocks[x, y + 1, z];
                        DestoryBlocks[x, y + 1, z] = null;
                    }
                    Block.stage[x, y, z] = Block.stage[x, y + 1, z];
                }
            }

        }
    }
}
