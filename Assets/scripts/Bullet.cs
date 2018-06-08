using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public float speed = 8f;
	// Use this for initialization
	void Start ()
    {
        rigidbody=GetComponent<Rigidbody2D>();
        rigidbody.velocity=transform.right*speed;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
