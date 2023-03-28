using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptParticle : MonoBehaviour
{
    public GameObject promptParticle;
    public bool isArrived = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isArrived)
        {
            promptParticle.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isArrived = true;


    }
    private void OnTriggerExit(Collider other)
    {
        isArrived = false;

    }
}
