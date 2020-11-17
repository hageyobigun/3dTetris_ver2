using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    [SerializeField] private Text scoreText;

    private void Update()
    {
        scoreText.text = "score : " + StageManeger.Instance.scoreValue.ToString();
    }
}
