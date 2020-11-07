using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private Transform blockPlace;

    public float fallSpeed;
    Vector3 RotationAngle;
    Vector3 Rot;
    private int posX, posY, posZ;
    private Vector3 movePosition = new Vector3(0, 0, 0);
    private int BlockNumbers;
    private int x2, z2;

    public static GameObject players;
    public List<GameObject> playBlock;

    private bool playerCount;
    private bool canMove;
    private bool canRotation = false;
    private bool canRotationCheck = true;
    private static bool canMoveCheck = false;

    private float PlayTime = 0;

	// Use this for initialization
	void Start () {
        
        BlockInstance();
	}

    // Update is called once per frame
    void Update()
    {
        PlayTime += Time.deltaTime;
        if (playerCount == true)
        {
            DestroyBlock.InDestoryList();
            DestroyBlock.destroyCheck();
            BlockInstance();
        }
        Move();
        Rotation();
        playerCount = PlayBlockManeger.BlockFall();

    }
    //移動
    void Move()
    {
        x2 = 0;
        z2 = 0;
        if(PlayTime >= 30)
        {
            fallSpeed += 0.01f;
            PlayTime = 0;
        }
        players.transform.position -= new Vector3(0, fallSpeed, 0);
        if (Input.GetKey(KeyCode.D))
        {
            players.transform.position -= new Vector3(0, 0.2f, 0);
        }
        movePosition = players.transform.position;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movePosition.z += 1;
            z2 = 1;
            canMoveCheck = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movePosition.z += -1;
            z2 = -1;
            canMoveCheck = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movePosition.x += -1;
            x2 = -1;
            canMoveCheck = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movePosition.x += 1;
            x2 = 1;
            canMoveCheck = true;
        }
        if (canMoveCheck == true)
        {
            canMove = PlayBlockManeger.MoveCheck(x2, z2);
            canMoveCheck = false;
        }
        if (canMove == true)
        {
            players.transform.position = Vector3.MoveTowards(players.transform.position, movePosition, 2.0f);
            canMove = false;
        }
    }

    //回転
    void Rotation()
    {
        Rot = new Vector3(0, 0, 0);
        RotationAngle = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.A))
        {
            RotationAngle.z = 90;
            Rot.z = -90;
            canRotationCheck = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            RotationAngle.y = 90;
            Rot.y = -90;
            canRotationCheck = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            RotationAngle.x = 90;
            Rot.x = -90;
            canRotationCheck = true;
        }
        if (canRotationCheck == true)
        {
            //回転可能か
            RotationMove(RotationAngle);
            canRotation = PlayBlockManeger.RotationPos();
            if (canRotation == false)
            {
                RotationMove(Rot);
            }
            canRotationCheck = false;
        }
    }

    //回転の動き
    private void RotationMove(Vector3 v)
    {
        players.transform.Rotate(Vector3.up, v.y, Space.World);
        players.transform.Rotate(Vector3.right, v.x, Space.World);
        players.transform.Rotate(Vector3.forward, v.z, Space.World);
    }


    //ブロック生成
    void BlockInstance()
    {
        BlockNumbers = Random.Range(0, 7);
        players = Instantiate(playBlock[BlockNumbers], new Vector3(Block.PlayerPos, 19f, Block.PlayerPos), Quaternion.identity);
        players.transform.SetParent(blockPlace, false);

        movePosition = players.transform.position;
        playerCount = false;

    }

}
