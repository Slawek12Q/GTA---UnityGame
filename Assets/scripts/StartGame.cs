using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	
    private void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }
}
