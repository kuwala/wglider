using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseLook : MonoBehaviour
{
    public float sensativity = 1;
    public Vector2 mousePosition = new Vector2(0,0);
    public Transform target;
    public bool easyLook = true;
    public bool shiftPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition.x = Input.GetAxis("Mouse X");
        mousePosition.y = Input.GetAxis("Mouse Y");
        if(Input.GetKeyDown(KeyCode.LeftShift)) {
            shiftPressed = true;
        }
        float sen = sensativity * (shiftPressed ? 3 : 1);
        if(easyLook)
        {
            print("easyloo");
            transform.RotateAround(target.position, new Vector3(mousePosition.y * sen, mousePosition.x * sen, 0), 0.9f);
        } else
        {
            transform.RotateAround(target.position, new Vector3(mousePosition.y * sen, mousePosition.x * sen, mousePosition.x * sen * -1), 0.9f);
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            easyLook = !easyLook;
            print("easyLook toggled!");
        }
    }
}
