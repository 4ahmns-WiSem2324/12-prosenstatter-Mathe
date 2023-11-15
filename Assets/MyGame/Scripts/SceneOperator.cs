using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class SceneOperator : MonoBehaviour
{
    public void OnButtonClick1()
    {
        SceneManager.LoadScene("Primzahlen",LoadSceneMode.Single);
      // EditorSceneManager.CloseScene(EditorSceneManager.GetSceneByName("MenuScene"), true);
    }

    public void OnButtonClick2()
    {
        SceneManager.LoadScene("Rechenübungen", LoadSceneMode.Single);
    }
    public void OnButtonClick3()
    {
        SceneManager.LoadScene("Teilbarkeitsregeln", LoadSceneMode.Single);
    }

    public void OnButtonClick4()
    {
        SceneManager.LoadScene("ZahlenErkennen", LoadSceneMode.Single);
    }


    public void OnButtonClickHome()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
}

