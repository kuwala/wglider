using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level_Exit : MonoBehaviour {
    public string SceneToLoad = "level1";
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

