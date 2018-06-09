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

        if(targ==null) return;

        targ.z=0f;

        Vector3 objectPos = transform.position;
        targ.x=targ.x-objectPos.x;
        targ.y=targ.y-objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(new Vector3(0, 0, angle));
        rigidbody.velocity=transform.right*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            var player = collision.gameObject.GetComponent<Player>();
            if(player.InvulnerabilityTime<Time.time)
            {
                collision.gameObject.GetComponent<HP>().HP_character-=1;
                player.InvulnerabilityTime=Time.time+3;
            }
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
