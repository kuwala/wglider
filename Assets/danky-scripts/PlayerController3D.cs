using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3D : MonoBehaviour
{
    public Vector3 moving = new Vector3();
    public int selectPlayer = 1; // 1, 2
    public bool actionPressed = false;
    public bool shiftPressed = false;
    public bool resetPressed = false;
    public bool telePressed = false;

    public bool stopPressed = false;
    void Start()
    {

    }

    void Update()
    {

        /* float t = Time.deltaTime;
        print("fixed dt: ");
        print(t);
        print("/n"); */
        moving.x = moving.y = moving.z = 0;
        if (selectPlayer == 1)
        {
            if (Input.GetKey("a"))
            {
                moving.x = 1;
            }
            else if (Input.GetKey("d"))
            {
                moving.x = -1;
            }

            if (Input.GetKey("s"))
            {
                moving.z = 1;
            }
            else if (Input.GetKey("w"))
            {
                moving.z = -1;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                moving.y = 1;
            }
        } else if (selectPlayer == 2)
        {
            if (Input.GetKey("joystick 1 button 8"))
            {
                moving.x = 1;
            }
            else if (Input.GetKey("joystick 1 button 7"))
            {
                moving.x = -1;
            }

            if (Input.GetKey("joystick 1 button 5"))
            {
                moving.z = 1;
            }
            else if (Input.GetKey("joystick 1 button 6"))
            {
                moving.z = -1;
            }
        } // end if selectPlayer == 2

        if (Input.GetKey(KeyCode.LeftShift))
        {
            shiftPressed = true;
        }
        else
        {
            shiftPressed = false;
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            actionPressed = true;
        }
        else
        {
            actionPressed = false;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            moving.y = 1;
        } else
        {
            moving.y = 0;
        }
        if (Input.GetKey("t"))
        {
            telePressed = true;
        }
        else
        {
            telePressed = false;
        }
        if (Input.GetKey(KeyCode.Home))
        {
            resetPressed = true;
        } else
        {
            resetPressed = false;
        }
        if( Input.GetKey("e")) {
            stopPressed = true;
        } else {
            stopPressed = false;
        }


    } // end update
}
