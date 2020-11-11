using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCamera : MonoBehaviour {


	[SerializeField] private GameObject mainCamera; //ステージによってカメラ位置を調整


	// Use this for initialization
	void Start () {
		mainCamera.transform.position = new Vector3(StageManeger.Instance.PlayerPos, 25f, StageManeger.Instance.PlayerPos); //カメラ位置調整
	}

}
