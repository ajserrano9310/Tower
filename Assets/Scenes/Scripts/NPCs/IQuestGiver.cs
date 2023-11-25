using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestGiver
{
    Quest quest { get; set; }
    void GivePlayerQuest();
}
