using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrimzahlPruefung : MonoBehaviour
{
    public TMP_InputField eingabeFeld;
    public TMP_Text ausgabeText;

    public void PruefePrimzahl()
    {
        string eingabeText = eingabeFeld.text;

        if (int.TryParse(eingabeText, out int zahl))
        {
            if (IstPrimzahl(zahl))
            {
                ausgabeText.text = zahl + " ist eine Primzahl.";
            }
            else
            {
                ausgabeText.text = zahl + " ist keine Primzahl.";
            }
        }
        else
        {
            ausgabeText.text = "Bitte geben Sie eine gültige Zahl ein.";
        }
    }

    bool IstPrimzahl(int zahl)
    {
        if (zahl <= 1)
        {
            return false;
        }

        if (zahl <= 3)
        {
            return true;
        }

        if (zahl % 2 == 0 || zahl % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= zahl; i += 6)
        {
            if (zahl % i == 0 || zahl % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }
}
