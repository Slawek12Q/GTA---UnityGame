using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    public float speed = 5f;

    public Sprite sprite;
	// Use this for initialization
	void Start ()
    {
        rigidbody=GetComponent<Rigidbody2D>();
        rigidbody.velocity=transform.right*speed;
	}

    // Update is called once per frame
    void Update ()
    {
        Vector2 current = transform.position;
        var direction = GameObject.FindGameObjectWithTag("Player").transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.AngleAxis(angle, Vector3.forward);
        rigidbody.velocity=transform.right*speed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
