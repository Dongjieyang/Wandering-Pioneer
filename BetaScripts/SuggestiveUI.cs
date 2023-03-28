using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuggestiveUI : MonoBehaviour
{
    public GameObject text;
    public bool isOpen = false;
    public bool isArrived = false;
    public GameObject Ui1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isOpen == false&&isArrived)
        {
            text.SetActive(true);
            isOpen = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && isOpen)
        {
            text.SetActive(false);
            isOpen = false;
        }

    }
 
    private void OnTriggerEnter(Collider other)
    {
        isArrived = true;
        Ui1.gameObject.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        isArrived = false;
        Ui1.gameObject.SetActive(false);

    }
    public void IsOpen()
    {
        isOpen = false;
    }
}


