using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPC : MonoBehaviour
{
    public UIManager manager;
    public abstract void HandlePlayerInteraction();
    public string NPCName;
    public long NPCId;

}
