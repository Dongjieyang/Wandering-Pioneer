using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyStationDoor : MonoBehaviour
{
    public Animator Door;
    private float EnterCount = 0;
    private void OnTriggerEnter(Collider other)
    {
        EnterCount++;

        if (EnterCount % 2 == 0)
        {
            Door.SetBool("EnergyStationDoorOpen", false);
        }

        else
        {
            Door.SetBool("EnergyStationDoorOpen", true);
        }
    }
}
