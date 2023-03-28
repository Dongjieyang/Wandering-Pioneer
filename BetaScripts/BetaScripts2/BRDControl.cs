using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BRDControl : MonoBehaviour
{
    public Animator brDoor;
    private float EnterCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        EnterCount++;

        if (EnterCount % 2 == 0)
        {
            brDoor.SetBool("BRDopen", false);
        }

        else
        {
            brDoor.SetBool("BRDopen", true);
        }
    }
    
}
