using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsCunter : MonoBehaviour {

    [SerializeField]
    Text Points;

    void Awake()
    {
        FindObjectOfType<Shoot>().BulletChanges += countBullets =>
        {
            Points.text = "Bullets " + countBullets.ToString();   
        };
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
