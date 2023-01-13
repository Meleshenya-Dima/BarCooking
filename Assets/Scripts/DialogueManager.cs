using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text PlayerName;

    public Text BuyerText;

    public Animator DialogBoxAnimator;

    public void StartDialogue(Dialogue dialogue)
    {
        string[] dialogueInformation = dialogue.GetDialogueInformation();

        DialogBoxAnimator.SetBool("IsOpen", true);


        PlayerName.text = "Hello " + dialogueInformation[0] + "!";
        StopAllCoroutines();
        StartCoroutine(WriteSentence(dialogueInformation[1]));
    }

    IEnumerator WriteSentence(string sentence)
    {
        BuyerText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            BuyerText.text += letter;
            yield return new WaitForSeconds(.02f);
        }
    }

    public void EndDialogue()
    {
        DialogBoxAnimator.SetBool("IsOpen", false);
    }
}
