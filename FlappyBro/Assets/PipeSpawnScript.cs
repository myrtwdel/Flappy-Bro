using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject Pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
        
    }

    void SpawnPipe()
    {
        float lowestPoint = 0 - heightOffset;
        float highestPoint = 0 + heightOffset;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
