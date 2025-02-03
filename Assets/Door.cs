using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorClosed, doorOpen, intIcon;
    
    // Start is called before the first frame update
    void Start()
    {
        intIcon.SetActive(false);
        doorOpen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intIcon.SetActive(true);
            if (Input.GetKey(KeyCode.E) && (doorClosed == true)) // Om jag klickar E och dörren är stängd, ska doorOpen aktiveras och doorClosed avaktiveras
            {
                intIcon.SetActive(false);
                doorOpen.SetActive(true);
                doorClosed.SetActive(false);
            }
            else
            {
                intIcon.SetActive(false);
                doorClosed.SetActive(true);
                doorOpen.SetActive(false);
            }

                            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intIcon.SetActive(false);
        }
    }
}
