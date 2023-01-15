using UnityEngine.EventSystems;
using UnityEngine;

public class ObjectClickController : MonoBehaviour, IPointerClickHandler
{
    private Transform _objectClick;

    void Start()
    {
        _objectClick = gameObject.GetComponent<Transform>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_objectClick.tag.Equals("Buyer"))
        {
            _objectClick.GetComponent<DialogueTrigger>().TriggerDialogue(_objectClick.gameObject);
        }
    }
}
