using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    //public float rotateXSpeed = 0.01f;
    float smooth = 5.0f;
    float tiltAngle = 60.0f;
    public Vector3 rotate = new Vector3(0, 5, 0);
    public bool rotateAroundSelfNotWorld = true;
    void Start()
    {
             
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rotateAroundSelfNotWorld)
        {
            transform.Rotate(rotate, Space.Self);
        } else
        {
            transform.Rotate(rotate, Space.World);
        }


        /***** something coool ???
        //transform.rotation.x = transform.rotation.x + rotateXSpeed
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        ********/

    } // end update
}
