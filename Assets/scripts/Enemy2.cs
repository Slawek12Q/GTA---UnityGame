using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    public GameObject Bullet;

    public float Speed = 3f;

    public float MinDistance = 4f;

    public float MaxDistance = 8f;

    public float Cooldown = 5f;

    public Sprite Sprite;
    
    void Start ()
    {
        rigidbody=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        if(player==null) return;

        Vector3 targ = player.transform.position;
        targ.z=0f;
        Vector3 objectPos = transform.position;
        targ.x=targ.x-objectPos.x;
        targ.y=targ.y-objectPos.y;
        float angle = Mathf.Atan2(targ.y, targ.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(new Vector3(0, 0, angle));

        if(Vector3.Distance(transform.position, player.transform.position)>=MinDistance)
        {
            rigidbody.velocity=transform.right*Speed;
        }
        if(Vector3.Distance(transform.position, player.transform.position)<=MaxDistance)
        {
            if(Time.time>Cooldown)
            {
                Instantiate(Bullet, transform.position+transform.rotation*new Vector2(0.3f, -0.15f), transform.rotation);
                Cooldown=Time.time+5;
            }
        }
    }
}
