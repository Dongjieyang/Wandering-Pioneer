using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2Generator : MonoBehaviour
{

    public GameObject Ui1;
    public GameObject text;
    public bool isOpen = false;
    public bool isArrived = false;
    public Animator v2Cover;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isOpen == false && isArrived)
        {
            v2Cover.SetBool("V2Opening", true);
            text.SetActive(true);
            isOpen = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && isOpen)
        {
            v2Cover.SetBool("V2Opening", false);
            text.SetActive(false);
            isOpen = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        
        Ui1.gameObject.SetActive(true);
        isArrived = true;

    }
    private void OnTriggerExit(Collider other)
    {
        
        Ui1.gameObject.SetActive(false);
        isArrived = false;

    }
}
