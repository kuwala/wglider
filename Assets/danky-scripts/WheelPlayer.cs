using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelPlayer : MonoBehaviour
{

    public float moveAcceleration = 6f;
    public float jumpAcceleration = 6f;
    public float shiftBoost = 3f;
    public Vector3 maxVelocity = new Vector3(12, 12, 12);
    public Vector3 maxBoostVelocity = new Vector3(24, 24, 24);
    private PlayerController3D controller;
    private Rigidbody rigidbody;
    public Vector3 respawnPosition;
    public Vector3 checkpointPosition;
    public Quaternion respawnRotation;
    public Vector3 pos;
    public Quaternion rot;
    public bool RotateControllerInput90 = true;
    void Start()
    {
        controller = GetComponent<PlayerController3D>();
        rigidbody = GetComponent<Rigidbody>();
        respawnRotation = transform.rotation;
        respawnPosition = transform.position;
        checkpointPosition = transform.position;
    }
    public void ResetPosition ()
    {
        transform.position = respawnPosition;
        transform.rotation = respawnRotation;
    }
    public void ResetToCheckpoint ()
    {
        transform.position = checkpointPosition;
    }
    public void ResetVelocity()
    {
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }
    public void setCheckpoint(Transform target)
    {
        checkpointPosition = target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (controller.resetPressed)
        {
            ResetPosition();
        }
        var forceX = 0f;
        var forceY = 0f;
        var forceZ = 0f; // will be for jump
        var absVelX = Mathf.Abs(rigidbody.velocity.x);
        var absVelY = Mathf.Abs(rigidbody.velocity.y);
        var absVelZ = Mathf.Abs(rigidbody.velocity.z);

        if(RotateControllerInput90 == false) {
            // normal movement
            if (controller.moving.x != 0)
            {
                if (absVelX < maxVelocity.x || (rigidbody.velocity.x > maxVelocity.x && controller.moving.x < 0) || (rigidbody.velocity.x < maxVelocity.x && controller.moving.x > 0))
                {
                    forceX = moveAcceleration * controller.moving.x;
                    // can change entity facing direction here
                }

            }

            if (controller.moving.z != 0)
            {
                if (absVelZ < maxVelocity.z || (rigidbody.velocity.z > maxVelocity.z && controller.moving.z < 0) || (rigidbody.velocity.z < maxVelocity.z && controller.moving.z > 0))
                {
                    forceX = moveAcceleration * controller.moving.z;
                }


            }
            if (controller.moving.y != 0)
            {
                if (absVelY < maxVelocity.y || (rigidbody.velocity.y > maxVelocity.y && controller.moving.y < 0) || (rigidbody.velocity.y < maxVelocity.y && controller.moving.y > 0))
                {
                    forceY = jumpAcceleration * 1f;
                }
            } //end n0rmal move
        } else {
            // rotated move
            if (controller.moving.x != 0)
            {
                if (absVelX < maxVelocity.x || (rigidbody.velocity.x > maxVelocity.x && controller.moving.x < 0) || (rigidbody.velocity.x < maxVelocity.x && controller.moving.x > 0))
                {
                    forceZ = moveAcceleration * controller.moving.x * -1.0F;
                    // can change entity facing direction here
                }

            }

            if (controller.moving.z != 0)
            {
                if (absVelZ < maxVelocity.z || (rigidbody.velocity.z > maxVelocity.z && controller.moving.z < 0) || (rigidbody.velocity.z < maxVelocity.z && controller.moving.z > 0))
                {
                    forceX = moveAcceleration * controller.moving.z;
                }


            }
            if (controller.moving.y != 0)
            {
                if (absVelY < maxVelocity.y || (rigidbody.velocity.y > maxVelocity.y && controller.moving.y < 0) || (rigidbody.velocity.y < maxVelocity.y && controller.moving.y > 0))
                {
                    forceY = jumpAcceleration * 1f;
                }
            } //end rot move
        }
        if (controller.actionPressed)
        {
            setCheckpoint(transform);
        }
        if (controller.telePressed)
        {
            ResetToCheckpoint();
        }
        if(controller.shiftPressed)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(forceX * shiftBoost, forceY, forceZ * shiftBoost));
        } else
        {

            GetComponent<Rigidbody>().AddForce(new Vector3(forceX, forceY, forceZ));
        }
        if(controller.stopPressed) {
            Vector3 vel = GetComponent<Rigidbody>().velocity;
            print(vel);
            print("vel^^");
            GetComponent<Rigidbody>().AddForce(new Vector3(vel.x * -8f, vel.y * -8f, vel.z * -8f));

        }
    }
}
