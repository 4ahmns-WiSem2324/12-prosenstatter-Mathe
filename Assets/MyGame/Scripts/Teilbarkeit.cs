using UnityEngine;
using UnityEngine.UI;

public class Teilbarkeitsregel : MonoBehaviour
{
    public InputField inputField;
    public Text resultText;

    public void TesteTeilbarkeit()
    {
        if (inputField != null)
        {
            string userInput = inputField.text;

            if (string.IsNullOrEmpty(userInput))
            {
                resultText.text = "Bitte eine Zahl eingeben!";
                return;
            }

            int number;

            if (!int.TryParse(userInput, out number))
            {
                resultText.text = "Ungültige Eingabe. Bitte eine ganze Zahl eingeben.";
                return;
            }

            string output = "";

            if (IstTeilbar(number, 2))
                output += "2, ";

            if (IstTeilbar(number, 3))
                output += "3, ";

            if (IstTeilbar(number, 5))
                output += "5, ";

            if (IstTeilbar(number, 7))
                output += "7, ";

            if (IstTeilbar(number, 9))
                output += "9, ";

            if (string.IsNullOrEmpty(output))
                resultText.text = number + " ist für keine der Regeln teilbar.";
            else
                resultText.text = number + " ist teilbar durch: " + output.TrimEnd(' ', ',');
        }
    }

    private bool IstTeilbar(int zahl, int teiler)
    {
        return zahl % teiler == 0;
    }
}
