using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public class DialogueInitializer
    {
        public static DialoguePart DialogInitialize()
        {
            DialoguePart result;
            string[] buttons = { "Łoddawaj passssata złodzjeju!!!", "Somsiad, jo ci dam somsiada łajdaku!", "Teraz sopbie pogadamy, nie masz gdzie uciec.", "Wrr (popraw skarpety w sandałach)" };
            string[] butonsSecondPart = { "Passat to nie wszystko somsiedzie.", "Może i tak ale n ciebie nawet bez pasata jestem z mocny!", "Łoż ty złodzjeju, jo ci dom kradzejstwo!", "Ty mi tu nie opwiadaj kocmołuchów, bo Grarzynka bigosu nagotowała i stygnie!" };
            string[] butonsFinalPart = { "Somsiad to jednak swój chłop!", "To może jeszce po maluszku na zgodę.. HEHE.", "Nie poznaje somsida, tuz to szlachetne zachowanie.", "(Odbierz kluczyki w milczeniu)......" };
            DialoguePart[] finalDialoguePart = { new DialoguePart(), new DialoguePart(), new DialoguePart(), new DialoguePart() };
            finalDialoguePart[0].NPCTextPart = "Trzymaj się!";
            finalDialoguePart[1].NPCTextPart = "Halinka by mnie z chałupy wywaliła, mówiła że ostatni raz to wytrzymuje takie zachowanie także w tym tygodniu to lipa z piciem. Może kiedy indziej, narazie spadam.";
            finalDialoguePart[2].NPCTextPart = "Każdy ma swoje ideały somsiedzie, żegnaj.";
            finalDialoguePart[3].NPCTextPart = "........................";
            DialoguePart[] secondDialoguePart = { new DialoguePart(), new DialoguePart(), new DialoguePart(), new DialoguePart("A więć nie jesteś taki za jakiego cię wziołem... stawieasz bigos nad materialne korzysci, dobrze więc proszę oto kluczyki do twojego passata.", butonsFinalPart, finalDialoguePart) };
            secondDialoguePart[0].NPCTextPart = "Ale wszystko bez passata to nic. Mam dosyć tych twojch gierek!";
            secondDialoguePart[1].NPCTextPart = "DOŚĆ! To twój koniec!";
            secondDialoguePart[2].NPCTextPart = "Niech zadecyduje próba walki, zobaczymy kto jest prawdziwym złodzjejem!";
            secondDialoguePart[3].pacificChoice = true;
            DialoguePart[] dialogs = {
            new DialoguePart(),
            new DialoguePart("No co mi zrobisz, bez passata nie masz żadnej mocy... BUAHAHAHAHAHA!",butonsSecondPart,secondDialoguePart),
            new DialoguePart(),
            new DialoguePart() };
            dialogs[0].NPCTextPart = "A więc tak, w takim razie niech ta cienciwa zaspiewa tango.";
            dialogs[2].NPCTextPart = "Ja mam passata, ty nie masz nic do gadania!";
            dialogs[3].NPCTextPart = "(Podrzuca kluczyki od passata i wkłada je do kieszeni) Rozjade cie jak passat rozjezdza kałuże!";
            result = new DialoguePart("Ło nie, tuż to somsiad!", buttons, dialogs);
            return result;
        }
    }
}
