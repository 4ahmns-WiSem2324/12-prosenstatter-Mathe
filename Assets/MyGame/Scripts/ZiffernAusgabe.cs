using UnityEngine;
using UnityEngine.UI;

public class ZiffernAusgabe : MonoBehaviour
{
    public Text ausgabeText;
    public int zahl = 311; // Hier Ihre Zahl eintragen
    private string ziffernText = "";
    private int del = 1234;
    public string deli;

    void Start()
    {
        AusgabeZiffern(zahl);
        deli = del.ToString();
        Debug.Log(int.Parse(deli.Remove(2, 1)));

    }

    void AusgabeZiffern(int num)
    {
        

        // Solange die Zahl größer als 0 ist
        while (num > 0)
        {
            int ziffer = num % 10; // Extrahiere die letzte Ziffer
            ziffernText = ziffer.ToString() + " " + ziffernText; // Füge die Ziffer zum Text hinzu
            num /= 10; // Entferne die letzte Ziffer
        }

        ausgabeText.text = "Ziffern: " + ziffernText;
    }


   
}
