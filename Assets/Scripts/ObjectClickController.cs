using UnityEngine.EventSystems;
using UnityEngine;

public class ObjectClickController : MonoBehaviour, IPointerClickHandler
{
    private Transform _objectClick;

    private bool _isOpenDoor = false;

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
        else if (_objectClick.tag.Equals("Door"))
        {
            _objectClick.GetComponent<Animator>().SetBool("IsOpen", !_isOpenDoor);
            _isOpenDoor = !_isOpenDoor;
        }
    }
}
