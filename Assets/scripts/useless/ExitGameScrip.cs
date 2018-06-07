using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGameScrip : MonoBehaviour {

    public Text score;
    public GameObject Record;

	void Start ()
    {
        var point = GetPoints();
        score.text = point.ToString() + " points";
        RefreshRecord();

    }
	
    int GetPoints ()
    {
        return PlayerPrefs.GetInt("acctuall_points", 0);
    }
    void RefreshRecord ()
    {
        var point = GetPoints();
        var recordPoint = PlayerPrefs.GetInt("record_points", 0);

        if(point > recordPoint)
        {
            PlayerPrefs.SetInt("record_points", point);
            Record.SetActive(true);
        }
        else
        {
            Record.SetActive(false);

        }

    }

}
