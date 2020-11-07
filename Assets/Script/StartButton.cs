using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public GameObject StartScene;
    public GameObject chooseStageScene;
    public GameObject StartButtonMusic;

	// Use this for initialization
	void Start () {
        StartButtonMusic.SetActive(false);
        chooseStageScene.SetActive(false);
	}
	

    public void ButtonOnStart()
    {
        StartButtonMusic.SetActive(true);
        StartScene.SetActive(false);
        chooseStageScene.SetActive(true);
    }
}
