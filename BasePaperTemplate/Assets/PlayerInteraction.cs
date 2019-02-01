using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {

    private bool isTalking = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "NPC" && Input.GetKeyDown("a"))
        {
            if(isTalking)
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }
            else
            {
                Debug.Log("Talking");
                isTalking = true;
                other.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isTalking = false;
    }

}
