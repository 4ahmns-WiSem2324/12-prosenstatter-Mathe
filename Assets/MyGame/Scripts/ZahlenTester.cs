using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZahlenTester : MonoBehaviour
{
    public InputField inputField;
    public Text ergebnisText;

    public void ÜberprüfeZahlentyp()
    {
        if (inputField != null)
        {
            string eingabe = inputField.text;

            if (string.IsNullOrEmpty(eingabe))
            {
                ergebnisText.text = "Bitte eine Zahl eingeben.";
                return;
            }

            if (IstNatürlicheZahl(eingabe))
            {
                ergebnisText.text = "Ganze Zahl";
            }
            else if (IstGanzeZahl(eingabe))
            {
                ergebnisText.text = "Natürliche Zahl";
            }
            else if (IstGleitkommazahl(eingabe))
            {
                ergebnisText.text = "Gleitkommazahl";
            }
            else
            {
                ergebnisText.text = "Ungültige Eingabe. Kein bekannter Zahlentyp.";
            }
        }
    }

    private bool IstGanzeZahl(string eingabe)
    {
        int zahl;
        return int.TryParse(eingabe, out zahl);
    }

    private bool IstNatürlicheZahl(string eingabe)
    {
        int zahl;
        if (int.TryParse(eingabe, out zahl))
        {
            return zahl >= 0;
        }
        return false;
    }

    private bool IstGleitkommazahl(string eingabe)
    {
        float zahl;
        return float.TryParse(eingabe, out zahl);
    }
}
