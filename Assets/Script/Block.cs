using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] private Transform stagePlace;
    public GameObject stageBlock;
    public  static int[,,] stage = new int[36, 36, 36];
    public static Vector3[] stage2 = new Vector3[100];
    public static int StageSize;
    public static int StageSizeCopy;
    public static int PlayerPos;
    public GameObject CameraPos;

	// Use this for initialization
	void Start()
    {
        StageSize = StageSize + 1;
        StageSizeCopy = StageSize;
        PlayerPos = StageSize + StageSize / 2;
        CameraPos.transform.position = new Vector3(PlayerPos, 25f, PlayerPos);
        StageInstance();
	}
	
	// Update is called once per frame
    void Update () {
        
	}
    
    //ステージ生成
    void StageInstance()
    {
        for (int x = 0; x < 36; x++)
        {
            for (int y = 0; y < 36; y++)
            {
                for (int z = 0; z < 36; z++)
                {
                    //壁は1
                    if (x == StageSize  || x == 2*StageSize  || z == StageSize || z == 2*StageSize)
                    {
                        stage[x, y, z] = 1;

                    }
                    //置いてくブロックは
                    else if (y == 0)
                    {
                        stage[x, y, z] = 2;

                    }
                    //それ以外は０
                    else
                    {
                        stage[x, y, z] = 0;
                    }
                }
            }
        }

        for (int x = StageSize; x < StageSize*2 + 1; x++)
        {
            for (int y = 0; y < 25; y++)
            {
                for (int z = StageSize; z < StageSize*2 + 1; z++)
                {
                    if (y == 0)
                    {
                        GameObject stages = Instantiate(stageBlock, new Vector3(x, y, z), Quaternion.identity);
                        stages.transform.SetParent(stagePlace, false);
                    }
                    else if (stage[x, y, z] ==  1)
                    {
                        GameObject stages = Instantiate(stageBlock, new Vector3(x, y, z), Quaternion.identity);
                        stages.transform.SetParent(stagePlace, false);
                    }
                }
            }
        }

    }


}
