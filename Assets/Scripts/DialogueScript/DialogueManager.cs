using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private GameObject buyerObject;

    public Text PlayerName;

    public Text BuyerText;

    public Animator DialogBoxAnimator;


    public void StartDialogue(Dialogue dialogue, GameObject transform)
    {
        buyerObject = transform;
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

    public void TakeOrder()
    {
        SendUpdateInformation();
    }

    public void DeclineOrder()
    {
        SendUpdateInformation();
        Destroy(buyerObject);
    }

    public void SendUpdateInformation()
    {
        int buyerIndexPosition = buyerObject.GetComponent<BuyerController>().StandIndexNow;
        DialogBoxAnimator.SetBool("IsOpen", false);
        buyerObject.GetComponent<BuyerController>().pathManager.BuyerUpdatePosition(buyerIndexPosition);
    }
}
