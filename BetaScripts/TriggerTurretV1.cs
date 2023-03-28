using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTurretV1 : MonoBehaviour
{
    public Animator turret1, turret2;
   

   public void CloseTurretV1()
    {
        turret1.SetBool("TurretV1", false);
        turret2.SetBool("TurretV1", false);
    }
   
}
