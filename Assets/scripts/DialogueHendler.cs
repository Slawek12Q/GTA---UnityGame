using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueHendler : MonoBehaviour {

    public Text NPCText;
    public Button DialogueOption1;
    public Button DialogueOption2;
    public Button DialogueOption3;
    public Button DialogueOption4;


    public void ChoisedOption1()
    {
        NPCText.GetComponent<Text>().text = "First option";
    }
    public void ChoisedOption2()
    {
        NPCText.GetComponent<Text>().text = "second option";
    }
    public void ChoisedOption3()
    {
        NPCText.GetComponent<Text>().text = "third option";
    }
    public void ChoisedOption4()
    {
        NPCText.GetComponent<Text>().text = "last option";
    }

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
