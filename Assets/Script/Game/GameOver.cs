using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver{

    //ブロックが一定以上積まれたらゲームオーバー
    public void CheckGameOver()
    {
        var stageRange = StageManeger.Instance.StageSize;

        for (int x = stageRange + 1; x < stageRange*2;x++)
        {
            for (int z = stageRange + 1; z < stageRange*2;z++)
            {
                if(StageManeger.Instance.stage[x, 20, z] == 2)
                {
                    GameEnd();
                }
            }
            
        }
    }

    private void GameEnd()
    {
        GameManeger.Instance.SetCurrentState(GameManeger.GameState.GameOver);
    }

}
