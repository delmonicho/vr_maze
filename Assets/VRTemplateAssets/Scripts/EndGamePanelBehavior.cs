using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGamePanelBehavior : MonoBehaviour
{

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinalOrb"))
        {
            // Broadcast to child MonoBehaviors, calling the child function specified
            gameObject.BroadcastMessage("ShowPanel");
        }

    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        gameObject.BroadcastMessage("HidePanel");
    //    }

    //}

}
