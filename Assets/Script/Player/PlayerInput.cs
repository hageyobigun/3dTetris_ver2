using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PlayerInput {

    public Vector3 moveDirection;
    public Vector3 angle;

    public Vector3 MoveBlock()
    {
        moveDirection = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveDirection = new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDirection = new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveDirection = new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveDirection = new Vector3(1, 0, 0);
        }
        return moveDirection;
    }

    public Vector3 RotationBlock()
    {
        angle = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.W))//x
        {
            angle = new Vector3(90, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))//y
        {
            angle = new Vector3(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))//z
        {
            angle = new Vector3(0, 0, 90);
        }
        return angle;
    }

    public bool IsUpFallSpeed() => Input.GetKey(KeyCode.D);
}
