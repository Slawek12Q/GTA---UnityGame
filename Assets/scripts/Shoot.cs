using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {


    [SerializeField]
    GameObject Bullet;

    public float bulletFast = 6f;

	void Start () {
		
	}
	
	
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
	}

    void Shooting()
    {
        var bullet = Instantiate(Bullet);
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;

        var bulletRigidBody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidBody.velocity = transform.right * bulletFast;
    }
}
