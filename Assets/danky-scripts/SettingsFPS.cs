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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
