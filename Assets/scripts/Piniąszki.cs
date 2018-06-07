using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piniąszki : MonoBehaviour {

    public int StartMoney = 200;
    private int dollars;
    public int Dollars
    {
        get { return dollars;}
        set
        {
            dollars = value;

            if(AddMoney != null)
            {
                AddMoney.Invoke(dollars);
            }
        }
    }

    public event Action <int> AddMoney;
	void Start () {

        Dollars = StartMoney;
	}
	
	
	void Update () {
		
	}
}
