using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.VersionControl;
using UnityEngine;

public class Shoot : MonoBehaviour {


    [SerializeField]
    GameObject Bullet;

    public Sprite[] Sprites;
    public int Time = 200;
    public Vector2 StartShoot;

    public float bulletFast = 6f;

    private int countBullets;

    public int CountBullets
    {
        get { return countBullets; }
        set {
            countBullets = value;

            if (BulletChanges != null)
                BulletChanges.Invoke(countBullets);

        }
    }

    public event Action<int> BulletChanges; 


    void Start () {

        CountBullets = 20;
        
	}
	
	
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            //ChangePlayer();
            Shooting();
        }
	}

    //void ChangePlayer()
    //{
    //    var renderer = GetComponent<SpriteRenderer>();
    //    renderer.sprite = Sprites[1];
        

    //}
    void Shooting()
    {
        //  var renderer = GetComponent<SpriteRenderer>();
        if (CountBullets == 0) return;

        CountBullets--;
        var bullet = Instantiate(Bullet);
        bullet.transform.position = transform.position + transform.rotation * (Vector3)StartShoot;
        bullet.transform.rotation = transform.rotation;
        var bulletRigidBody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidBody.velocity = transform.right * bulletFast;
      //  renderer.sprite = Sprites[0];
    }
}
