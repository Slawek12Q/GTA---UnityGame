using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ItemsWhichICanCollect))]
public class CountOfBulletsInItems : MonoBehaviour {

	void Start ()
    {
        var activator = GetComponent<ItemsWhichICanCollect>();
        activator.OnActivate += () =>
        {
            if(activator.KindOfItems == 1)
            {
                var player = FindObjectOfType<Player>();
                int amount = Random.Range(1, 10);
                player.BulletCount += amount;
                Destroy(gameObject);
            }
            else if (activator.KindOfItems == 2)
            {
                var player = FindObjectOfType<HP>();
                int amount = Random.Range(1, 10);
                player.HP_character += amount;
                Destroy(gameObject);
            }
            else
            {
                var player = FindObjectOfType<Piniąszki>();
                int amount = Random.Range(10, 200);
                player.Dollars += amount;
                Destroy(gameObject);
            }
           
        };

	}
	
	void Update () {
		
	}
}
