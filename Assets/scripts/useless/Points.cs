using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    int Point = 0;

	void Start ()
    {
        SafePoints();
        RefreshPoints();	
	}
    void SafePoints ()
    {
        PlayerPrefs.SetInt("acctuall_points", Point);
    }
	
    public void AddPoints()
    {
        Point++;
        SafePoints();
        RefreshPoints();
    }

    void RefreshPoints()
    {
        GetComponent<Text>().text = Point + " points";

    }
}
