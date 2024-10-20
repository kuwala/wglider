using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCameraFollower : MonoBehaviour
{
    public GameObject target;
    public GameObject helpUI;
    public float zoomValue = 2.0f;
    private Transform _t;
    private Transform cameraInitialT;
    private Quaternion initialR;
    private bool zToggle = true; // toggles adding to the z distance
    //Vector3 positionOffset = new Vector3(0, 2, 4);
    public Vector3 positionOffset = new Vector3(0, 0, 0);
    public bool helpUIToggle = false;
    // Start is called before the first frame update
    private void Awake()
    {
        // This is for pixel perfect view for 2d cames
        //GetComponent<Camera>().orthographicSize = ((Screen.height / zoomValue / 32f));
    }
    void Start()
    {
        //cameraInitialT = this.transform;
        initialR = this.transform.rotation;
        _t = target.transform;
    }
    public void resetCameraRotation()
    {
        this.transform.rotation = initialR;
    }

    // Update is called once per frame
    void Update()
    {
        float _x = _t.position.x + positionOffset.x + zoomValue*0.1f;
        float _y = _t.position.y + positionOffset.y + zoomValue;
        float _z = _t.position.z + positionOffset.z + (zToggle ? 1.5f : -1.5f) + zoomValue;

        transform.position = new Vector3(_x, _y, _z);

        if (Input.GetKeyDown(KeyCode.R))
        {
            //this.transform.rotation = cameraInitialT.rotation;
            this.transform.rotation = initialR;
            print("R pressed in camera script");
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            zToggle = !zToggle;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            helpUIToggle = !helpUIToggle;
            if(helpUIToggle)
            {
                helpUI.SetActive(true);
            } else
            {
                helpUI.SetActive(false);
            }
            
        }
        
    }
}
