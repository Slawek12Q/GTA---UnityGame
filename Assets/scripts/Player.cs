using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    public float PlayerSpeed = 2f;
    public float ChangeFast = 8f;
    Crosshair crosshair;

    Rigidbody2D rigidBody;
    void Start () {
		
	}
	
	private void Awake ()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        crosshair = FindObjectOfType<Crosshair>();


    }
	void Update ()
    {
        ChangePosition();
        ChangeRotation();

    }

   
    private void ChangePosition()
    {
        var PlayerDirection = Vector3.zero;
        PlayerDirection += Vector3.up * Input.GetAxis("Vertical");
        PlayerDirection += Vector3.right * Input.GetAxis("Horizontal");

        PlayerDirection = PlayerDirection.normalized * PlayerSpeed;
        rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, PlayerDirection, Time.deltaTime * 4f);
        
    }

    private void ChangeRotation()
    {
        var findCursor = crosshair.transform.position - transform.position;
        var targetRotation = (Vector2)findCursor;
        transform.right = Vector3.Lerp(transform.right, targetRotation, Time.deltaTime* 10f);

        //transform.right = PlayerDirection;


    }
}
