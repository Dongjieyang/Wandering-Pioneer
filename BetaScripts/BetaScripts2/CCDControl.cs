using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCDControl : MonoBehaviour
{
    public Animator ccdoor;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {


        ccdoor.SetBool("CCDopen", true);
        Invoke("Wait1", 3.0f);
    }
    void Wait1()
    {
        ccdoor.SetBool("CCDopen", false);
    }
}
