using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (var col in colliderArray)
            {
                if (col.TryGetComponent<NPC>(out NPC interactiveNpc))
                {
                    interactiveNpc.HandlePlayerInteraction();
                }

            }
        }

    }
}
