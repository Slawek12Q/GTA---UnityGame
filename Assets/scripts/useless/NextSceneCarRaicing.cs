using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(ItemsWhichICanCollect))]
public class NextSceneCarRaicing : MonoBehaviour {

	
	void Start () {
        var activator = GetComponent<ItemsWhichICanCollect>();
        activator.OnActivate += () =>
        {
            if(FindObjectOfType<Player>().kluczyki == true)
                SceneManager.LoadScene("Start");
        };
    }
	
	
}
