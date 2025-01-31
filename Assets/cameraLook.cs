using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerLook : MonoBehaviour
{
    public float mouseSens = 100;

    public Transform playerBody;

    float Xrotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90, 90);

        transform.localRotation = Quaternion.Euler(Xrotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
