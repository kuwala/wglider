using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterCloneObject : MonoBehaviour
{
    public Transform cloneLocation;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (prefab != null && cloneLocation != null) {
            //         Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(prefab, cloneLocation.position, Quaternion.identity);

        }
        
    }
}
