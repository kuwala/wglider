using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 120;
        //set resolution to 1080p
        // QualitySettings.resolution = new Vector2(1920, 1080);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
