using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    private float time;
    public GameObject spawnObject;
    public float spawnCoolTime;

    void Awake()
    {
        time = 0f; 
    }

    // Update is called once per frame
    void Update()
    {
        if(time > spawnCoolTime)
        {
            Instantiate(spawnObject);
            time = 0;
        }
        time += Time.deltaTime;
    }
}
