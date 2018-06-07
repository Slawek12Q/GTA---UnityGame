using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public float minSpawnRangeTime = 1.0f;
    
    public float maxSpawnRangeTime = 3.0f;
    
    public float baseSpawnWaitTime = 3.0f;

    // Use this for initialization
    void Start ()
    {
        baseSpawnWaitTime+=Random.Range(minSpawnRangeTime, maxSpawnRangeTime);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Time.time>baseSpawnWaitTime)
        {
            baseSpawnWaitTime+=Random.Range(minSpawnRangeTime, maxSpawnRangeTime);
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
	}
}
