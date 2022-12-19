using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trade : MonoBehaviour
{
    public GameObject barrel;
    public GameObject energyBox;
    public GameObject stater;

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E)&&barrel.gameObject .activeSelf==false&& energyBox.gameObject.activeSelf == false)
        {
            stater.gameObject.SetActive(true);

        }


    }
}
