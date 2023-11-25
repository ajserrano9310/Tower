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
    QuestManagerScript qm = QuestManagerScript.Instance;
    List<NPC> GameNPCs = new List<NPC>();
    void Start()
    {
        var objs = FindObjectsOfType<QuestGiver>();
        Debug.Log("The total amount of quest givers: " + objs.Length);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
