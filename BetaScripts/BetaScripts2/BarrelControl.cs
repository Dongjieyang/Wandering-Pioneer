using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelControl : MonoBehaviour
{

    public GameObject Barrel1, Barrel2, Barrel3;
    public GameObject exitCollider;

    void Update()
    {
       if(exitCollider.gameObject.GetComponent<TankDoorClose>().throughtNum==1)
        {
            Barrel1.gameObject.GetComponent<BoxCollider>().enabled = true;
            Barrel2.gameObject.GetComponent<BoxCollider>().enabled = true;
            Barrel3.gameObject.GetComponent<BoxCollider>().enabled = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if(gameObject.activeSelf==false)
        {
            Barrel1.gameObject.GetComponent<BoxCollider>().enabled = false;
            Barrel2.gameObject.GetComponent<BoxCollider>().enabled = false;
            Barrel3.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }



   
        
}
