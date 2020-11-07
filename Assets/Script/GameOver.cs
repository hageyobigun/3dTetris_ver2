using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {


    public string SceneName;
    public int stageRange;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        checkGameOver();
	}

    void checkGameOver()
    {
        stageRange = Block.StageSizeCopy;

        for (int x = stageRange + 1; x < stageRange*2;x++)
        {
            for (int z = stageRange + 1; z < stageRange*2;z++)
            {
                if(Block.stage[x, 20, z] == 2)
                {
                    GameOverText();
                }
            }
            
        }
    }

    void GameOverText()
    {
        SceneManager.LoadScene(SceneName);
    }


}
