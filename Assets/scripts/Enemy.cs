using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    public float Speed = 3f;

    Vector2 GoalPosition;

    public GameObject [] Sprite;

    void Start ()
    {
        rigidbody=GetComponent<Rigidbody2D>();
        StartCoroutine(ChangeActualPosition());
        FindObjectOfType<Enemy>().GetComponent<HP>().Killed += () =>
        {
            int x = UnityEngine.Random.Range(0, Sprite.Length - 1);
            var items = Instantiate(Sprite[x]);
            items.transform.position = transform.position;
            items.GetComponent<ItemsWhichICanCollect>().KindOfItems = UnityEngine.Random.Range(1, 3);
            Destroy(gameObject);
        };
    }

    void Update ()
    {
        var player = GameObject.FindGameObjectWithTag("Player");

        if(player==null) return;

        Vector3 objectPos = (Vector3)GoalPosition - transform.position;
        var objectSpeed = objectPos.normalized *Speed;
        rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, objectSpeed, Time.deltaTime);

        transform.right = (Vector2)objectPos;

        //float angle = Mathf.Atan2(targ.y, targ.x)*Mathf.Rad2Deg;
        //transform.rotation=Quaternion.Euler(new Vector3(0, 0, angle));
        //rigidbody.velocity=transform.right*Speed;
    }

    IEnumerator ChangeActualPosition()
    {
        while (true)
        {
            GoalPosition = (Vector2)transform.position + UnityEngine.Random.insideUnitCircle * 10f;
            yield return new WaitForSeconds(4);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var player = collision.gameObject.GetComponent<Player>();
            if (player.InvulnerabilityTime < Time.time)
            {
                collision.gameObject.GetComponent<HP>().HP_character -= 1;
                player.InvulnerabilityTime = Time.time + 2;
            }
        }
    }

    private void OnDestroy()
    {

    }
}
