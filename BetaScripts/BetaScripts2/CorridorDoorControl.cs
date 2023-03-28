using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorDoorControl : MonoBehaviour
{
    public Animator CorridorDoor1;
    private void OnTriggerEnter(Collider other)
    {
        CorridorDoor1.SetBool("isCorridorDoor1Close", true);

    }
}
