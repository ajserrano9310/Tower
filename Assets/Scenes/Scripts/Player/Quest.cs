using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Quest
{
    public long QuestID;
    public string QuestName;
    public bool IsActive;
    public bool ShouldShowToPlayer;
    public Quest()
    {

    }
}
