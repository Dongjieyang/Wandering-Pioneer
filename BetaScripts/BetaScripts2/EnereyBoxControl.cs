using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnereyBoxControl : MonoBehaviour
{
    public GameObject Box1, Box2;
    public GameObject exitCollider;

    void Update()
    {
        if (exitCollider.gameObject.GetComponent<StructureDoorClose>().throughtNum == 1)
        {
            Box1.gameObject.GetComponent<BoxCollider>().enabled = true;
            Box2.gameObject.GetComponent<BoxCollider>().enabled = true;
           
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (gameObject.activeSelf == false)
        {
            Box1.gameObject.GetComponent<BoxCollider>().enabled = false;
            Box2.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
           
    }
}
