using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public float speed = 6f;
	// Use this for initialization
	void Start ()
    {
        rigidbody=GetComponent<Rigidbody2D>();
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
