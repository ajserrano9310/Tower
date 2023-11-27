using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManagerScript
{
    Dictionary<string, Quest> QuestAndNPCsValues = new Dictionary<string, Quest>();
    private static QuestManagerScript instance;
    public static QuestManagerScript Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new QuestManagerScript();
            }

            return instance;
        }
    }
    public void ActivateQuest(string questId)
    {
        QuestAndNPCsValues[questId].ShouldShowToPlayer = true;
        // TODO:
        // Show some type of message for the player
    }
    public Dictionary<string, Quest> GetQuestDict()
    {
        return QuestAndNPCsValues;
    }

    public Quest GetQuest(string NpcName)
    {
        return QuestAndNPCsValues[NpcName];
    }

    public void LoadQuestsOnStart(QuestLoader[] quests)
    {

    }
}
