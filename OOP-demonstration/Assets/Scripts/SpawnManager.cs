using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    private float startTime = 2.0f;
    private float repeatRate = 1.0f;

    [SerializeField]
    private BaseSphere[] sphereArray = new BaseSphere[3];

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSpheres",startTime,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnSpheres()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(8.0f, 10.0f), Random.Range(-5.0f, 5.0f));
        Instantiate(sphereArray[Random.Range(0, 3)], spawnPosition, gameObject.transform.rotation);
    }
}
