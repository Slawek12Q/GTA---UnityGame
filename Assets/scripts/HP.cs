using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int InitialHP = 10;
    public event Action Killed;
    public event Action<int> ChangeHP;
    private int hp_character;
    public int HP_character
    {
        get { return hp_character; }
        set
        {

            hp_character = value;

            if(ChangeHP != null)
            {
                ChangeHP.Invoke(hp_character);
            }

            if(hp_character <= 0)
            {
                if(Killed != null)
                {
                    Killed.Invoke();
                }

                Destroy(gameObject);
            }

        }
    }
	void Start ()
    {
        HP_character = InitialHP;
	}
	
	
	void Update () {
		
	}
}
