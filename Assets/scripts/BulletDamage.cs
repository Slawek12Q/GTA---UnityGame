using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collision2D))]
public class BulletDamage : MonoBehaviour {

    public int Damage = 1;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D (Collision2D collision)
    {
        var health = collision.gameObject.GetComponent<HP>();

        if (health != null)
            health.HP_character -= Damage;

        Destroy(gameObject);
    }
}
