using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ItemsWhichICanCollect : MonoBehaviour {

    public bool IsActive = false;
    public bool ActiveItem { get; set; }
    public event Action OnActivate;
    /// <summary>
    /// 1 to przedmioty dodające amunicji 
    /// 2 to przedmioty dodajace zdrowie 
    /// 3 to przedmioty dodajace pieniądze
    /// </summary>
    public int KindOfItems = 1;
	void Start () {
		
	}
	
	
	void Update ()
    {
        if (IsActive)
        {
            ChangeColor();
        }

        CollectItems();

    }

    private void CollectItems()
    {
        if (IsActive)
        {
            if (ActiveItem)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (OnActivate != null)
                        OnActivate.Invoke();

                }
            }

        }
    }

    private void ChangeColor()
    {
        if (ActiveItem == true)
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }

        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        ActiveItem = true;
    }

    private void OnTriggerExit2D (Collider2D collider)
    {
        ActiveItem = false;
    }


}
