using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pause : MonoBehaviour {

    private bool StopScene = false;
    public Text PauseText;
    public AudioSource StopMusic;


    void Start()
    {
        PauseText.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        PauseButton();
    }

    void PauseButton()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (StopScene == true)
            {
                StopMusic.Play();
                PauseText.enabled = false;
                GetComponent<Player>().enabled =true;
                StopScene = false;
                return;
            }
            if(StopScene == false)
            {
                StopMusic.Stop();
                PauseText.enabled = true;
                GetComponent<Player>().enabled = false;
                StopScene = true;
                return;
            }
        }
    }

}
