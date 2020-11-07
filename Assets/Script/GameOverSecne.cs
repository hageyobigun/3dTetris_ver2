using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverSecne : MonoBehaviour {

    public Text GameoverText;
    public Text LastScore;
    public GameObject Last;

    public float finishIntarval = 0;

	// Use this for initialization
	void Start () {
        LastScore.text = "score : " + Score.scoreValue.ToString();
        Last.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        finishIntarval += Time.deltaTime;
        if(finishIntarval >= 3)
        {
            ScoreOpen();
        }
	}

    void ScoreOpen()
    {
        GameoverText.enabled = false;
        Last.SetActive(true);
    }

}
