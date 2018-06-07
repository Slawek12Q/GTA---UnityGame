using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

    UnityEngine.Camera Camera;

    void Start () {

        Camera = FindObjectOfType<UnityEngine.Camera>();
	}
	
	void Update ()
    {
        var mousePosition = Input.mousePosition;
        var boardPosition = Camera.ScreenToWorldPoint(mousePosition);
        transform.position = (Vector2)boardPosition;
	}
}
