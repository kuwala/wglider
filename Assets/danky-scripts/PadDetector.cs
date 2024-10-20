using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// has issues detecting 2 per wheel. see computer-notes for details

public class PadDetector : MonoBehaviour
{
    public GameObject targetObject;
    public int numberPresent = 0;
    public bool isTriggered = false;
    public int threshold = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( numberPresent >= threshold ) {
            isTriggered = true;
        } else {
            isTriggered = false;
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "WheelAgent") {
            numberPresent++;
        }
        // if(other.GetComponent<WheelPlayer>() != null){
        //     numberPresent++;

        // }

    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "WheelAgent") {
            numberPresent--;
        }
        // if(other.GetComponent<WheelPlayer>() != null) {
        //     numberPresent--;
        // }
    }
}
