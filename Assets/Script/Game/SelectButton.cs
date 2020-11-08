using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButton : MonoBehaviour {


    public void onStart6()
    {
        Score.scoreValue = 0;
        Block.StageSize = 6;
        SceneManager.LoadScene("Play");
    }
    public void onStart8()
    {
        Score.scoreValue = 0;
        Block.StageSize = 8;
        SceneManager.LoadScene("Play");
    }
    public void onStart10()
    {
        Score.scoreValue = 0;
        Block.StageSize = 10;
        SceneManager.LoadScene("Play");
    }
}
