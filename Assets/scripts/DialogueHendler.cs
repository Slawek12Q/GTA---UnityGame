using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Classes;
public class DialogueHendler : MonoBehaviour {

    public Text NPCText;
    public Text DialogueOption1;
    public Text DialogueOption2;
    public Text DialogueOption3;
    public Text DialogueOption4;
    private DialoguePart actualDialogue;

    public void ChoisedOption1()
    {   
        if(actualDialogue.TextDialogues[0] != null && actualDialogue.TextDialogues[0].NPCTextPart != null)
            NPCText.GetComponent<Text>().text = actualDialogue.TextDialogues[0].NPCTextPart;
        else
            NPCText.GetComponent<Text>().text = "Koniec rozmowy";
    }
    public void ChoisedOption2()
    {
        if (actualDialogue.TextDialogues[1] != null && actualDialogue.TextDialogues[1].NPCTextPart != null)
            NPCText.GetComponent<Text>().text = actualDialogue.TextDialogues[1].NPCTextPart;
        else
            NPCText.GetComponent<Text>().text = "Koniec rozmowy";
        //W elsie koniec rozmowy
    }
    public void ChoisedOption3()
    {
        if (actualDialogue.TextDialogues[2] != null && actualDialogue.TextDialogues[2].NPCTextPart != null)
            NPCText.GetComponent<Text>().text = actualDialogue.TextDialogues[2].NPCTextPart;
        else
            NPCText.GetComponent<Text>().text = "Koniec rozmowy";
    }
    public void ChoisedOption4()
    {
        if (actualDialogue.TextDialogues[3] != null && actualDialogue.TextDialogues[3].NPCTextPart != null)
            NPCText.GetComponent<Text>().text = actualDialogue.TextDialogues[3].NPCTextPart;
        else
            NPCText.GetComponent<Text>().text = "Koniec rozmowy";
        
    }
    
    void Start()
    {
        string[] buttons = { "Łoddawaj passssata złodzjeju!!!","Somsiad, jo ci dam somsiada łajdaku!","Teraz sopbie pogadamy, nie masz gdzie uciec.","Wrr (popraw skarpety w sandałach)" };
        DialoguePart[] dialogs = { new DialoguePart(), new DialoguePart(), new DialoguePart(), new DialoguePart() };
        actualDialogue = new DialoguePart("Ło nie, tuż to somsiad!",buttons,dialogs); 
        NPCText.text = actualDialogue.NPCTextPart;
        DialogueOption1.text = actualDialogue.Answsers[0];
        DialogueOption2.text = actualDialogue.Answsers[1];
        DialogueOption3.text = actualDialogue.Answsers[2];
        DialogueOption4.text = actualDialogue.Answsers[3];
    }
    // Update is called once per frame
    void Update () {
		
	}
    
}
