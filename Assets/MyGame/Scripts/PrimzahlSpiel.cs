using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrimzahlSpiel : MonoBehaviour
{
    public TMP_Text primzahlText;
    public TMP_Text ausgabeText;

    private int zufaelligeZahl;

    void Start()
    {
        GeneriereZufaelligePrimzahl();
    }

    void GeneriereZufaelligePrimzahl()
    {
        zufaelligeZahl = Random.Range(1, 101);
        primzahlText.text = "Ist " + zufaelligeZahl + " eine Primzahl?";
    }

    public void PruefeAntwort(bool istPrimzahl)
    {
        bool korrekteAntwort = IstPrimzahl(zufaelligeZahl) == istPrimzahl;

        if (korrekteAntwort)
        {
            ausgabeText.text = "Richtig!";
        }
        else
        {
            ausgabeText.text = "Falsch!";
        }

        GeneriereZufaelligePrimzahl();
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
