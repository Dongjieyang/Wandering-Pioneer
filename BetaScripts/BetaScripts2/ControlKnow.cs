using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlKnow : MonoBehaviour
{
    public GameObject controlKnow1;
    public GameObject controlKnow2;
    public GameObject controlKnow3, controlKnow4;
    public Component movementScript;
    public GameObject startUi;
    bool triggerOnce;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(startUi.activeSelf==false&&triggerOnce==false)
        {
            Invoke("Wait1", 1);
            triggerOnce = true;
        }
    }
    void Wait1()
    {
        controlKnow1.SetActive(true);
        Invoke("Wait2", 3);
    }
    void Wait2()
    {
        movementScript.GetComponent<Movement>().enabled = true;
        controlKnow1.SetActive(false);
        controlKnow2.SetActive(true);
        Invoke("Wait3", 7);
    }
    void Wait3()
    {
        controlKnow2.SetActive(false);
        controlKnow3.SetActive(true);
        controlKnow4.SetActive(true);

    }


}
