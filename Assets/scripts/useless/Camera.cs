using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform TrackedObject;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(
            transform.position.x,
            TrackedObject.position.y+4f,
            transform.position.z
            );
		
	}
}
