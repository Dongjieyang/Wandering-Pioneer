using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrived : MonoBehaviour
{
    public bool arrived;
   
    void OnTriggerStay()
    {
        arrived = true;

    }
    void OnTriggerExit()
    {
        arrived = false;

    }
}
