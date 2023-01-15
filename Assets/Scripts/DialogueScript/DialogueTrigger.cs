using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void Start()
    {
        dialogue = FindObjectOfType<DialogueManager>().GetComponent<Dialogue>();
    }

    public void TriggerDialogue(GameObject gameObject)
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, gameObject);
    }
}
