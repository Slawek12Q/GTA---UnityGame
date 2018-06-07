using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerainGenerator : MonoBehaviour {

    public GameObject[] Terrain;
    public GameObject StartBlock;
    private int Index = 0;
    private List<GameObject> ActualBlocks = new List<GameObject>();
	void Start ()
    {
		for (int i=0; i<5; i++)
        {
            GenerateSinglePart();
        }
	}
	
	
	void Update ()
    {
		
	}

    void GenerateSinglePart()
    {
        var index = Random.Range(0, Terrain.Length-1);
        var prefab = Terrain[index];

        if(Index < 2 )
        {
            prefab = StartBlock;
        }
        var block = Instantiate(prefab);
        ActualBlocks.Add(block);
        block.transform.position = Vector2.up * Index * 13.3f;
        GetComponent<BoxCollider2D>().transform.position = Vector2.up * (Index-2) * 13.3f;
        Index++;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GenerateSinglePart();
        var block = ActualBlocks.First();
        Destroy(block);
        ActualBlocks.RemoveAt(0);
        CarMovement.CarSpeed += 0.005f;
    }
}
