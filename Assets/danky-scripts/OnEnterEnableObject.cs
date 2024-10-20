using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterEnableObject : MonoBehaviour
{
    public GameObject[] obj;
    public WheelPlayer player;
    public TargetCameraFollower camera;
    public bool ResetPlayer = false;
    public bool disableSelf = true;
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
        if(disableSelf)
        {
            this.gameObject.SetActive(false);
        }
        // obj.SetActive(true);
        foreach (GameObject o in obj)
        {
            o.SetActive(true);
        }
        if(ResetPlayer)
        {
            //player.ResetToCheckpoint();
            player.ResetPosition();
            player.ResetVelocity();
            camera.resetCameraRotation();
        }
    }
}
