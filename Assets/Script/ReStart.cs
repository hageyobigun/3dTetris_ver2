using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReStart : MonoBehaviour {

    public string SceneName;
    public string Starts;
    public AudioSource ButtonMusic;

    // Use this for initialization
    void Start()
    {
        ButtonMusic.Stop();
    }

    //リスタート
    public void onClick()
    {
        ButtonMusic.Play();
        Block.StageSize += -1;
        Score.scoreValue = 0;
        SceneManager.LoadScene(SceneName);
    }
    //スタート画面へ
    public void onStart()
    {
        ButtonMusic.Play();
        Score.scoreValue = 0;
        SceneManager.LoadScene(Starts);
    }


}
