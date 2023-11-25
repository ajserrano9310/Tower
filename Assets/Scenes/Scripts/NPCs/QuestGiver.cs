using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : NPC, IQuestGiver
{
    public Quest quest { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public QuestManagerScript questManager;
    public GameManager GM;

    public void GivePlayerQuest()
    {
        Debug.Log("Giving player quest");
    }

    public override void HandlePlayerInteraction()
    {
        Debug.Log("Interacting");
        GM.uIManager.DisplayDialogUI();

    }

}
