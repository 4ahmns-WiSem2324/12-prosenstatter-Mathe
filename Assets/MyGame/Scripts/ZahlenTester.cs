using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZahlenTester : MonoBehaviour
{
    public InputField inputField;
    public Text ergebnisText;

    public void �berpr�feZahlentyp()
    {
        if (inputField != null)
        {
            string eingabe = inputField.text;

            if (string.IsNullOrEmpty(eingabe))
            {
                ergebnisText.text = "Bitte eine Zahl eingeben.";
                return;
            }

            if (IstNat�rlicheZahl(eingabe))
            {
                ergebnisText.text = "Ganze Zahl";
            }
            else if (IstGanzeZahl(eingabe))
            {
                ergebnisText.text = "Nat�rliche Zahl";
            }
            else if (IstGleitkommazahl(eingabe))
            {
                ergebnisText.text = "Gleitkommazahl";
            }
            else
            {
                ergebnisText.text = "Ung�ltige Eingabe. Kein bekannter Zahlentyp.";
            }
        }
    }

    private bool IstGanzeZahl(string eingabe)
    {
        int zahl;
        return int.TryParse(eingabe, out zahl);
    }

    private bool IstNat�rlicheZahl(string eingabe)
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
