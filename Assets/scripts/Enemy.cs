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
        Vector3 targ = GameObject.FindGameObjectWithTag("Player").transform.position;
        targ.z=0f;

        Vector3 objectPos = transform.position;
        targ.x=targ.x-objectPos.x;
        targ.y=targ.y-objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(new Vector3(0, 0, angle));
        rigidbody.velocity=transform.right*speed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
