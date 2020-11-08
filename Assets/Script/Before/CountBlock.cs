using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountBlock : MonoBehaviour {

    public Text [] countText;
    private int []Count;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        onBlockCount();
	}

    void onBlockCount()
    {
        Count = new int[15];
        for (int y = 1; y < 15; y++)
        {
            for (int x = Block.StageSize; x < Block.StageSize * 2 + 1; x++)
            {
                for (int z = Block.StageSize; z < Block.StageSize * 2 + 1; z++)
                {
                    if (Block.stage[x, y, z] == 2)
                    {
                        Count[y]++;
                    }
                }
            }
            countText[y].text = y.ToString() + ":" + Count[y].ToString();
        }
    }
}
