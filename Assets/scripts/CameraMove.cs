using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform cameraTarget;
    
    public float cameraSpeed;
    
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if(cameraTarget!=null)
        {
            var newPos = Vector2.Lerp(transform.position, cameraTarget.position, Time.deltaTime*cameraSpeed);
            
            var vect3 = new Vector3(newPos.x, newPos.y, -10f);

            // Clamp gets the cameras x position and clamps
            // it between the min and max value
            var clampX = Mathf.Clamp(vect3.x, minX, maxX);
            var clampY = Mathf.Clamp(vect3.y, minY, maxY);

            // Move the camera
            transform.position=new Vector3(clampX, clampY, -10f);
        }
    }
}
