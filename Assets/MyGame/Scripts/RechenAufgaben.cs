using UnityEngine;
using UnityEngine.UI;

public class Rechenaufgaben : MonoBehaviour
{
    public Text aufgabenText;
    public InputField antwortInputField;
    public Text ergebnisText;

    private int zahl1;
    private int zahl2;
    private char operatorChar;
    private int erwarteteAntwort;

    private void Start()
    {
        ErstelleAufgabe();
    }

    public void ErstelleAufgabe()
    {
        
        zahl1 = Random.Range(0, 101);
        zahl2 = Random.Range(0, 101);

       
        operatorChar = ZufälligerOperator();

       
        erwarteteAntwort = BerechneAntwort(zahl1, zahl2, operatorChar);

        // Den Aufgabentext generieren und anzeigen
        aufgabenText.text = $"{zahl1} {operatorChar} {zahl2} = ?";
    }

    public void ÜberprüfeAntwort()
    {
        if (antwortInputField != null)
        {
            int benutzerAntwort;

            if (int.TryParse(antwortInputField.text, out benutzerAntwort))
            {
                if (benutzerAntwort == erwarteteAntwort)
                    ergebnisText.text = "Richtig!";
                else
                    ergebnisText.text = "Falsch. Versuche es erneut.";
            }
            else
            {
                ergebnisText.text = "Ungültige Eingabe. Bitte eine ganze Zahl eingeben.";
            }
        }
    }

    private char ZufälligerOperator()
    {
        char[] operatoren = { '+', '-', '*', '/' };
        return operatoren[Random.Range(0, operatoren.Length)];
    }

    private int BerechneAntwort(int zahl1, int zahl2, char operatorChar)
    {
        switch (operatorChar)
        {
            case '+':
                return zahl1 + zahl2;
            case '-':
                return zahl1 - zahl2;
            case '*':
                return zahl1 * zahl2;
            case '/':
                if (zahl2 == 0) // Division durch Null verhindern
                    return 0;
                return zahl1 / zahl2;
            default:
                return 0;
        }
    }
}
