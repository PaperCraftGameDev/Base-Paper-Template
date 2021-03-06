﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text dialogueText;
    private Queue<string> sentences;

    public Animator animator;

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
	}

    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();

        animator.SetBool("IsOpen", true);

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    //Call to display the next message in a dialogue
    //Returns true if there are still sentences in the dialogue
    //Returns false when the dialogue is complete
    public bool DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return false;
        }

        string currentSentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(currentSentence));
        return true;
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
	
    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }

}
