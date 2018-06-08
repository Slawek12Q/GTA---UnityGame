using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInterface : MonoBehaviour
{

    [SerializeField]
    Text Points;
    [SerializeField]
    Text Health;
    [SerializeField]
    Text Money;

    void Awake()
    {
        FindObjectOfType<Player>().BulletChanges += countBullets =>
        {
            Points.text = "Bullets " + countBullets.ToString();   
        };

        FindObjectOfType<Player>().GetComponent<HP>().ChangeHP += hp_character =>
        {
            Health.text = "HP " + hp_character.ToString();
        };

        FindObjectOfType<Player>().GetComponent<Piniąszki>().AddMoney += dollars =>
        {
            Money.text = "Piniąszki " + dollars.ToString();
        };
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
