using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectElement : MonoBehaviour
{
    public GameObject element;
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            element.SetActive(false);
            CollectUI.maxNun += 1;

        }


    }
}
