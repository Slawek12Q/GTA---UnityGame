using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public class DialoguePart
    {
        public string NPCTextPart { get; set; }
        public string[] Answsers = new string[4];
        public DialoguePart[] TextDialogues = new DialoguePart[4];
        public bool pacificChoice = false;
        public DialoguePart()
        {

        }
        public DialoguePart(string npctext,string[] answers,DialoguePart[]nextDialogues)
        {
            NPCTextPart = npctext;
            for (int i = 0;i< 4; i++)
            {
                if(answers.Length > i)
                {
                    Answsers[i] = answers[i];
                }
                else
                {
                    Answsers[i] = "Koniec rozmowy";
                }

                if (nextDialogues.Length > i)
                {
                    TextDialogues[i] = nextDialogues[i];
                }
            }
        }
    }
}
