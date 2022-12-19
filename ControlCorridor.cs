using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCorridor : MonoBehaviour
{
    public GameObject door1;
    public GameObject corridor1;
    public bool controlFirst = false;
    public bool pressOnce=true;
   
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E)&&pressOnce==true)
        {
            door1.SetActive(false);
            corridor1.transform.Rotate(0, 120, 0);
            controlFirst = true;
            pressOnce = false;

        }


    }
}
