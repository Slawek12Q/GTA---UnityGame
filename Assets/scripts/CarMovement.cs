using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

    public static float CarSpeed;
	
	void Start () {
        CarSpeed = 0.07f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        CarMove();

    }

    private void CarMove()
    {
        transform.Translate(Vector3.up * CarSpeed);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var AktualPosition = transform.position;
            if(transform.position.x > -2.35f)
            {
                transform.position = AktualPosition + Vector3.left * 0.1f;
            }
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var AktualPosition = transform.position;
            if(transform.position.x < 1.5f)
            {
                transform.position = transform.position + Vector3.right * 0.1f;
            }
            
        }
    }
}
