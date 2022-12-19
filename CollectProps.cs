using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectProps : MonoBehaviour
{
    public GameObject item;
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            item.SetActive(false);

        }


    }
}
