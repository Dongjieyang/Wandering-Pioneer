using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public GameObject Ui1;
    private void OnTriggerEnter(Collider other)
    {
        
        Ui1.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
       
        Ui1.gameObject.SetActive(false);
    }
}
