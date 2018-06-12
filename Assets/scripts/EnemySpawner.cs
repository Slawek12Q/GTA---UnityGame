using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public float MinSpawnRangeTime = 1.0f;
    
    public float MaxSpawnRangeTime = 3.0f;
    
    public float BaseSpawnWaitTime = 3.0f;

    private List<GameObject> spawns=new List<GameObject>();

    void Start ()
    {
        BaseSpawnWaitTime+=Random.Range(MinSpawnRangeTime, MaxSpawnRangeTime);
	}
	
	void Update ()
    {
		if(Time.time>BaseSpawnWaitTime)
        {
            for(int i = 0;i<spawns.Count;++i)
            {
                if(spawns[i]==null)
                {
                    spawns.RemoveAt(i);
                    --i;
                }
            }
            BaseSpawnWaitTime+=Random.Range(MinSpawnRangeTime, MaxSpawnRangeTime);
            if(spawns.Count<7)
            {
                spawns.Add(Instantiate(enemy, transform.position, Quaternion.identity));
            }
        }
	}
}
