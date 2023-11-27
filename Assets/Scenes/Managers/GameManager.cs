using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private static GameManager instance;
    public static GameManager Instance => instance ?? new GameManager();

    public UIManager uIManager;
    public QuestLoader[] QuestLoader;
    public Dictionary<string, string[]> DialogueInteractions = new Dictionary<string, string[]>() {
        {"Maria", new string[ ] {"Hello", "Goodbye"} },
        {"Carlos", new string[ ] {"Hello", "Goodbye"} },
    };
    QuestManagerScript qm = QuestManagerScript.Instance;
    List<NPC> GameNPCs = new List<NPC>();

    void Start()
    {

    }
}
