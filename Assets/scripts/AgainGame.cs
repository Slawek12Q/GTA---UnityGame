using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AgainGame : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Board");
        
    }

    //void Update()
    //{
    //    if(Input.GetKey(KeyCode.Escape))
    //    {
    //        Application.Quit();
    //    }

    //}


}
