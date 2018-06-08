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
    public Button DialogueButton1;
    public Button DialogueButton2;
    public Button DialogueButton3;
    public Button DialogueButton4;
    private DialoguePart actualDialogue = null;

    public void ChoisedOption1()
    {
        if (actualDialogue.TextDialogues[0] != null && actualDialogue.TextDialogues[0].NPCTextPart != null)
        {
            actualDialogue = actualDialogue.TextDialogues[0];
            NPCText.GetComponent<Text>().text = actualDialogue.NPCTextPart;
            updateButtons();
        }
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
        actualDialogue = setDialogue(); 
    }
    // Update is called once per frame
    void Update () {
        if (!DialogueButton1.enabled && !DialogueButton2.enabled && !DialogueButton3.enabled && !DialogueButton4.enabled)
            Debug.Log("Koniec Gadania");
	}

    private DialoguePart setDialogue()
    {
        DialoguePart result;
        string[] buttons = { "Łoddawaj passssata złodzjeju!!!", "Somsiad, jo ci dam somsiada łajdaku!", "Teraz sopbie pogadamy, nie masz gdzie uciec.", "Wrr (popraw skarpety w sandałach)" };
        DialoguePart[] dialogs = {
            new DialoguePart(),
            new DialoguePart(),
            new DialoguePart(),
            new DialoguePart() };
        dialogs[0].NPCTextPart = "A więc tak, w takim razie niech ta cienciwa zaspiewa tango.";
        result = new DialoguePart("Ło nie, tuż to somsiad!", buttons, dialogs);
        NPCText.text = result.NPCTextPart;
        DialogueOption1.text = result.Answsers[0];
        DialogueOption2.text = result.Answsers[1];
        DialogueOption3.text = result.Answsers[2];
        DialogueOption4.text = result.Answsers[3];
        return result;
    }

    private void updateButtons()
    {
        if (actualDialogue.Answsers.Length == 4)
        {
            if (actualDialogue.Answsers[0] != null)
                DialogueOption1.text = actualDialogue.Answsers[0];
            else { 
                DialogueButton1.enabled = false;
                DialogueOption1.text = "";
            }
            if (actualDialogue.Answsers[1] != null)
                DialogueOption2.text = actualDialogue.Answsers[1];
            else
            {
                DialogueButton2.enabled = false;
                DialogueOption2.text = "";
            }
            if (actualDialogue.Answsers[2] != null)
                DialogueOption3.text = actualDialogue.Answsers[2];
            else
            {
                DialogueButton3.enabled = false;
                DialogueOption3.text = "";
            }
            if (actualDialogue.Answsers[3] != null)
                DialogueOption4.text = actualDialogue.Answsers[3];
            else
            {
                DialogueButton4.enabled = false;
                DialogueOption4.text = "";
            }
        }
    }
    
}
