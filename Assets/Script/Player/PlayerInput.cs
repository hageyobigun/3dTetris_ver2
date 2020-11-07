using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput {


    public void MoveBlock()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
    }

    public bool IsRotation_z => Input.GetKeyDown(KeyCode.A);
    public bool IsRotation_y => Input.GetKeyDown(KeyCode.S);
    public bool IsRotation_x => Input.GetKeyDown(KeyCode.W);

}
