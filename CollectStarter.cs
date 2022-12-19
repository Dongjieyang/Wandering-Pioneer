using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStarter : MonoBehaviour
{
    public GameObject starter;

    public bool gotStarter = false;

   
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            starter.SetActive(false);
            gotStarter = true;

        }


    }
}
