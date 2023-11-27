using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;

public class UIManager : MonoBehaviour
{
    List<string> statements = new List<string>() {
        "Hello",
        "Goodbye"
    };
    public GameObject TextUI;
    public GameObject InfoUI;
    void Start()
    {
        TextUI.gameObject.SetActive(false);
        InfoUI.gameObject.SetActive(false);
    }

    public void HideDialogBox(GameObject OpenedUIElement)
    {
        OpenedUIElement.gameObject.SetActive(false);
    }

    public void DisplayDialogUI(string[] dialogue)
    {
        InfoUI.gameObject.SetActive(true);
        //Text
        // InfoUI.gameObject.
    }
}
