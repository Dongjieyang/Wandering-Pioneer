using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlKnow : MonoBehaviour
{
    public GameObject controlKnow1;
    public GameObject controlKnow2;
    public GameObject controlKnow3;
    public GameObject controlKnow4;
    public Component movementScript;
    public bool isFirst = false;
    public bool isSecond = false;
    void Start()
    {
        Invoke("Wait1", 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0 || (Input.GetAxis("Horizontal") != 0) )
        {
            if (isFirst == true)
            {
                Invoke("Wait3", 4);
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if( isSecond == true)
            {
                Invoke("Wait4", 4);
            }
        }
    }
    void Wait1()
    {
        controlKnow1.SetActive(true);
        Invoke("Wait2", 3);
    }
    void Wait2()
    {
        isFirst = true;
        movementScript.GetComponent<Movement>().enabled = true;
        controlKnow1.SetActive(false);
        controlKnow2.SetActive(true);
    }
    void Wait3()
    {
        isFirst = false;
        controlKnow2.SetActive(false);
        controlKnow3.SetActive(true);
        isSecond = true;
    }
    void Wait4()
    {
        isSecond = false;
        controlKnow3.SetActive(false);
        controlKnow4.SetActive(true);
        Invoke("Wait5", 5);
    }
    void Wait5()
    {
        controlKnow4.SetActive(false);
    }
}
