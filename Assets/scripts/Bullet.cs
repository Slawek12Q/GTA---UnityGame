﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    public float Speed = 8f;

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
