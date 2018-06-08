using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class DialoguePart
    {
        public string NPCTextPart { get; set; }
        public string[] Answsers = new string[4];
        public DialoguePart[] AextDialogues = new DialoguePart[4];
        DialoguePart()
        {

        }
        DialoguePart(string npctext,string[] answers,DialoguePart[]nextDialogues)
        {

        }
    }
}
