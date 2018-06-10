using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    public float Speed = 6f;

    void Start ()
    {
        rigidbody=GetComponent<Rigidbody2D>();
        rigidbody.velocity=transform.right*Speed;
    }
	
	void Update ()
    {
		
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
