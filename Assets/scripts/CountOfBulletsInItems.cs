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
            else if (activator.KindOfItems == 3)
            {
                var player = FindObjectOfType<Piniąszki>();
                int amount = Random.Range(10, 200);
                player.Dollars += amount;
                Destroy(gameObject);
            }
            else if (activator.KindOfItems == 4)
            {
                var player = FindObjectOfType<Player>();
                player.PlayerSpeed = 3;
                Destroy(gameObject);
            }
            else if (activator.KindOfItems == 5)
            {
                var player = FindObjectOfType<BulletDamage>();
                player.Damage = 2;
                Destroy(gameObject);
            }
            else if (activator.KindOfItems == 6)
            {
                var player = FindObjectOfType<Player>();
                player.GetComponent<Bullet>().Speed = 12;
                Destroy(gameObject);
            }
            else if (activator.KindOfItems == 7)
            {
                var player = FindObjectOfType<Player>();
                player.kluczyki = true;
                Destroy(gameObject);
            }


        };

	}
	
	void Update () {
		
	}
}
