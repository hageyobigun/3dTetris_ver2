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
	private PlayerPut playerPut;
	private GameObject block;

	[SerializeField] private float fallSpeed;

	// Use this for initialization
	void Start () {
		playerInput = new PlayerInput();
		playerMove = new PlayerMove();
		playerRotation = new PlayerRotation();
		playerPut = new PlayerPut();
		playerBlock = GetComponent<PlayerBlock>();

		block = playerBlock.BlockInstance();

		//生成
		this.UpdateAsObservable()
            .Where(_ => playerPut.IsPut(block))
            .Subscribe(_ => block = playerBlock.BlockInstance());

        //移動
        this.UpdateAsObservable()
			.Where(_ =>  playerInput.MoveBlock() != new Vector3(0, 0, 0))
			.Subscribe(_ => playerMove.BlockMove(block, playerInput.moveDirection));

		//回転
		this.UpdateAsObservable()
			.Where(_ => playerInput.RotationBlock() != new Vector3(0, 0, 0))
			.Subscribe(_ => playerRotation.Rotation(block, playerInput.angle));

		this.UpdateAsObservable()
			.Subscribe(_ => block.transform.position -= new Vector3(0, fallSpeed, 0));

		this.UpdateAsObservable()
			.Where(_ => playerInput.IsUpFallSpeed())
			.Subscribe(_ => block.transform.position -= new Vector3(0, fallSpeed * 2, 0));
	}
}
