using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class PlayerController : MonoBehaviour {

	private PlayerInput playerInput;
	private PlayerMove playerMove;
	private PlayerRotation playerRotation;
	private PlayerBlock playerBlock;

	// Use this for initialization
	void Start () {
		playerInput = new PlayerInput();
		playerMove = new PlayerMove();
		playerRotation = new PlayerRotation();
		playerBlock = GetComponent<PlayerBlock>();


		this.UpdateAsObservable()
			.Subscribe(_ => playerBlock.BlockInstance());
	}
	
	// Update is called once per frame
	void Update () {



	}
}
