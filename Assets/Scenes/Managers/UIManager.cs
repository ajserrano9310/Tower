using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;
using TMPro;
using Debug = UnityEngine.Debug;

public class UIManager : MonoBehaviour
{
    #region Private class fields
    List<string> statements = new List<string>() {
        "Hello",
        "Goodbye"
    };
    KeyCode _dialogueKey = KeyCode.Q;
    float _delayBetweenDialogues = 1f;
    int diagIndex = 0;
    bool isDialogueInProgress = false;
    string[] conversation;
    #endregion

    #region Public class fields
    public GameObject TextUI;
    public GameObject InfoUI;
    public TextMeshProUGUI textToChange;
    #endregion 

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
        conversation = dialogue; 

        //StartCoroutine(GetNextDialogueLine(dialogue));
    }

    public IEnumerator GetNextDialogueLine()
    {
        isDialogueInProgress = true;
        Debug.Log(conversation[diagIndex]);
        yield return new WaitForSeconds(_delayBetweenDialogues);

        diagIndex++; 

        if(diagIndex > conversation.Length - 1)
        {
            // end conversation
            diagIndex = 0;
        }

        isDialogueInProgress = false; 
    }
    public void Update()
    {
        if(Input.GetKeyDown(_dialogueKey) && !isDialogueInProgress)
        {
            StartCoroutine(GetNextDialogueLine());
        }   
    }
}
