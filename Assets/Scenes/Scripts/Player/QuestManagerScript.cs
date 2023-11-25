using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManagerScript
{
    Dictionary<long, Quest> QuestAndNPCsValues = new Dictionary<long, Quest>();
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
    public void ActivateQuest(long questId)
    {
        QuestAndNPCsValues[questId].ShouldShowToPlayer = true;
        // TODO:
        // Show some type of message for the player
    }
    public Dictionary<long, Quest> GetQuestDict()
    {
        return QuestAndNPCsValues;
    }

    public void LoadQuestsOnStart(QuestLoader[] quests)
    {

    }
}
