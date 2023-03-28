using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorToStation : MonoBehaviour
{
    public GameObject v2Screen,energyStationDoorCol,promptCol,doorScreen1, doorScreen2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(v2Screen.gameObject.activeSelf==false)
        {
            energyStationDoorCol.gameObject.SetActive(true);
            promptCol.gameObject.SetActive(false);
            doorScreen1.gameObject.SetActive(false);
            doorScreen2.gameObject.SetActive(false);
        }
    }
}
