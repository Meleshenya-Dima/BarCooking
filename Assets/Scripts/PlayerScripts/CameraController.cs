using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float MouseX;
    private float MouseY;
    public float sensitivityMouse = 200f;

    public Transform player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        MouseX = Input.GetAxis("Mouse X") * sensitivityMouse * Time.deltaTime;
        MouseY = Input.GetAxis("Mouse Y") * sensitivityMouse * Time.deltaTime;

        if (transform.localRotation.x >= 0.4)
        {
            transform.localRotation = new Quaternion(0.39f, transform.localRotation.y, transform.localRotation.z, transform.localRotation.w);
        }
        else if (transform.localRotation.x <= -0.2)
        {
            transform.localRotation = new Quaternion(-0.19f, transform.localRotation.y, transform.localRotation.z, transform.localRotation.w);
        }
        else
        {
            player.Rotate(MouseX * new Vector3(0, 1, 0));
            transform.Rotate(-MouseY * new Vector3(1, 0, 0));
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            Cursor.lockState = CursorLockMode.Confined;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
