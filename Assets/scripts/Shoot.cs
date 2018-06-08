using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.VersionControl;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;

    public int Time = 200;

    public Vector2 StartShoot;

    public float bulletFast = 8f;

    private int countBullets;

    public int CountBullets
    {
        get { return countBullets; }
        set
        {
            countBullets = value;

            if (BulletChanges != null)
                BulletChanges.Invoke(countBullets);

        }
    }

    public event Action<int> BulletChanges; 

    void Start ()
    {
        CountBullets = 20;
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
        if (CountBullets == 0) return;

        --CountBullets;

        var bullet = Instantiate(Bullet, transform.position+transform.rotation*(Vector3)StartShoot, transform.rotation);
        SoundManager.Instance.PlayOneShot(SoundManager.Instance.gunFire);
    }
}
