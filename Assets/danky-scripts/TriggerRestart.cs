using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRestart : MonoBehaviour
{
    public WheelPlayer player;
    public TargetCameraFollower follower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        player.ResetPosition();
        player.ResetVelocity();
        follower.resetCameraRotation();
    }
}
