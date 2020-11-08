using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : SingletonMonoBehaviour<GameManeger>{

	public enum GameState
	{
		Start,
		Playing,
		GameOver
	}

	// Use this for initialization
	void Start () {
		
	}

    void GameStart()
    {

    }

    public void GameOver()
    {

    }

    public void StartGame()
    {

    }
    public void ExplainImage()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("終わり");
    }


}
