using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject TextUI;
    void Start()
    {
        TextUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
