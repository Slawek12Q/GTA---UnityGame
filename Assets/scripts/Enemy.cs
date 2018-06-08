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
        rigidbody.velocity=Vector3.down*speed;
	}

    // Update is called once per frame
    void Update ()
    {
        //var player = GameObject.FindGameObjectWithTag("Player");
        //transform.LookAt(player.transform.position);
        //transform.position+=transform.forward*speed*Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //public void LookAt2D(this Transform transform, Vector2 target)
    //{
    //    Vector2 current = transform.position;
    //    var direction = target-current;
    //    var angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
    //    transform.rotation=Quaternion.AngleAxis(angle, Vector3.forward);
    //}
}
