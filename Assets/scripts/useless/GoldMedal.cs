using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMedal : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collider)
    {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;
        FindObjectOfType<Points>().AddPoints();
        Destroy(gameObject, 3f);
    }
}
