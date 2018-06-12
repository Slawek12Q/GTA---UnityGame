using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Classes;
using UnityEngine.SceneManagement;

public class DialogueHendler : MonoBehaviour
{

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
    private bool end = false;
    private bool fight = true;
    private bool isTyping = false;

    public void ChoisedOption1()
    {
        if (!isTyping)
            if (actualDialogue.TextDialogues[0] != null && actualDialogue.TextDialogues[0].NPCTextPart != null)
            {
                actualDialogue = actualDialogue.TextDialogues[0];
                StartCoroutine(typeSentence(actualDialogue.NPCTextPart, NPCText.GetComponent<Text>()));
                updateButtons();
            }
            else
            {
                fightOrNot();
            }
    }
    public void ChoisedOption2()
    {
        if(!isTyping)
            if (actualDialogue.TextDialogues[1] != null && actualDialogue.TextDialogues[1].NPCTextPart != null)
            {
                actualDialogue = actualDialogue.TextDialogues[1];
                StartCoroutine(typeSentence(actualDialogue.NPCTextPart, NPCText.GetComponent<Text>()));
                updateButtons();
            }
            else
            {
                fightOrNot();
            }

    }
    public void ChoisedOption3()
    {
        if (!isTyping)
            if (actualDialogue.TextDialogues[2] != null && actualDialogue.TextDialogues[2].NPCTextPart != null)
            {
                actualDialogue = actualDialogue.TextDialogues[2];
                StartCoroutine(typeSentence(actualDialogue.NPCTextPart, NPCText.GetComponent<Text>()));
                updateButtons();
            }
            else
            {
                fightOrNot();
            }
    }
    public void ChoisedOption4()
    {
        if (!isTyping)
            if (actualDialogue.TextDialogues[3] != null && actualDialogue.TextDialogues[3].NPCTextPart != null)
            {
                actualDialogue = actualDialogue.TextDialogues[3];
                StartCoroutine(typeSentence(actualDialogue.NPCTextPart, NPCText.GetComponent<Text>()));
                updateButtons();
            }
            else
            {
                fightOrNot();
            }

    }

    void Start()
    {
        actualDialogue = setDialogue();
    }

    void Update()
    {
        if (end || (!DialogueButton1.enabled && !DialogueButton2.enabled && !DialogueButton3.enabled && !DialogueButton4.enabled))
        {
            end = true;
            DialogueOption1.text = "Zakończ rozmowę.";
            DialogueButton1.enabled = true;
        }
    }

    private DialoguePart setDialogue()
    {
        DialoguePart result = DialogueInitializer.DialogInitialize(); 
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
            if (actualDialogue.pacificChoice)
                fight = false;
            if (actualDialogue.Answsers[0] != null)
                DialogueOption1.text = actualDialogue.Answsers[0];
            else
            {
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

    IEnumerator typeSentence(string text, Text toType)
    {
        isTyping = true;
        toType.text = "";
        foreach (char letter in text.ToCharArray())
        {
            toType.text += letter;
            yield return null;
        }
        isTyping = false;
    }

    private void fightOrNot()
    {
        if(fight)
        {
            SceneManager.LoadScene("Board");
        }
        else
        {
            FindObjectOfType<Player>().kluczyki = true;
            SceneManager.LoadScene("main");
        }
    }

}
