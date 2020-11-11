using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour {

    public void ReStartButton()
    {
        GameManeger.Instance.SetCurrentState(GameManeger.GameState.Playing);
    }

    public void TitleButton()
    {
        GameManeger.Instance.SetCurrentState(GameManeger.GameState.Start);
    }

}
