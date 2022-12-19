using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCorridor2 : MonoBehaviour
{
    public GameObject door2;
    public GameObject corridor1;
    public GameObject corridor2;
    public GameObject corridor3;
    public Transform movecorr;
    public bool controlFirst=false;
    public Component controlCorr;
    public bool pressOnce = true;
    // Update is called once per frame
    void Update()
    {
        controlFirst = controlCorr.GetComponent<ControlCorridor>().controlFirst;
    }
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E)&&controlFirst==true)
        {
            if (pressOnce == true)
            {
                door2.SetActive(false);
                corridor1.transform.Rotate(0, -120, 0);
                corridor2.transform.position = movecorr.position;
                corridor3.transform.Rotate(0, -100, 0);
                pressOnce = false;
            }
        }


    }
}
