﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public float speed = 5f;

    public Sprite sprite;
	// Use this for initialization
	void Start ()
    {
        rigidbody=GetComponent<Rigidbody2D>();
        rigidbody.velocity=Vector3.down*speed;
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