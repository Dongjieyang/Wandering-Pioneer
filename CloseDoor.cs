using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject starter;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(starter.activeSelf==false)
        {
            door.SetActive(true);
        }
    }
}
