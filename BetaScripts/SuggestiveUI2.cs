using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuggestiveUI2 : MonoBehaviour
{
    public GameObject text;

    public bool isArrived = false;
    public GameObject Ui1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)&&isArrived)
        {
            text.SetActive(true);    
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
}
