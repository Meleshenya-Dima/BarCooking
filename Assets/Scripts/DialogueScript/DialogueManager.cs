using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private GameObject buyerObject;

    public Text PlayerName;

    public Text BuyerOrderText;

    public Animator DialogBoxAnimator;

    public OrderManager orderManager;

    private string _order;

    public Transform SpawnZone;

    public void StartDialogue(Dialogue dialogue, GameObject transform)
    {
        buyerObject = transform;
        string[] dialogueInformation = dialogue.GetDialogueInformation();

        DialogBoxAnimator.SetBool("IsOpen", true);
        _order = dialogueInformation[1];
        PlayerName.text = "Hello " + dialogueInformation[0] + "!";
        StopAllCoroutines();
        StartCoroutine(WriteSentence(_order));
    }

    IEnumerator WriteSentence(string sentence)
    {
        BuyerOrderText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            BuyerOrderText.text += letter;
            yield return new WaitForSeconds(.02f);
        }
    }

    public void TakeOrder()
    {
        bool isAdd = orderManager.AddOrderList(_order);
        if (isAdd)
        {
            SendUpdateInformation();
            buyerObject.GetComponent<BuyerController>().DanceZonePosition(SpawnZone);
        }
        else
        {
            DialogBoxAnimator.SetBool("IsOpen", false);
        }
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
