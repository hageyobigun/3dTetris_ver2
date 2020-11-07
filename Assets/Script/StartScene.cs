using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScene : MonoBehaviour {

    public string SceneName;
    public GameObject StartMusic;

    // Use this for initialization
    void Start()
    {
        StartMusic.SetActive(false);
    }

    public void onStart6()
    {
        StartMusic.SetActive(true);
        Score.scoreValue = 0;
        Block.StageSize = 6;
        SceneManager.LoadScene(SceneName);
    }
    public void onStart8()
    {
        StartMusic.SetActive(true);
        Score.scoreValue = 0;
        Block.StageSize = 8;
        SceneManager.LoadScene(SceneName);
    }
    public void onStart10()
    {
        StartMusic.SetActive(true);
        Score.scoreValue = 0;
        Block.StageSize = 10;
        SceneManager.LoadScene(SceneName);
    }

}
