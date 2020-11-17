using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButton : MonoBehaviour {

    
    public void onStart6()//6 6マス
    {
        GameManeger.Instance.stagesize = 6;
        GameManeger.Instance.SetCurrentState(GameManeger.GameState.Playing);
    }
    public void onStart8()//8 8マス
    {
        GameManeger.Instance.stagesize = 8;
        GameManeger.Instance.SetCurrentState(GameManeger.GameState.Playing);

    }
    public void onStart10()//10 10マス
    {
        GameManeger.Instance.stagesize =10;
        GameManeger.Instance.SetCurrentState(GameManeger.GameState.Playing);
    }

    public void Game_end_button()
    {
        Application.Quit();
    }
}
