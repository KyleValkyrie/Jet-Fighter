using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject Spawner;
    public bool stopSpawing = false;
    public float spawnTime = 5f;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(Spawner, transform.position, transform.rotation);
        if(stopSpawing)
        {
            CancelInvoke("SpawnObject");
        }
    }
    
}
