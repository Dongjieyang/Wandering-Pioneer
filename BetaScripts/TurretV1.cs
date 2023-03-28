using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretV1 : MonoBehaviour
{
    public Animator turret1, turret2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        turret1.SetBool("TurretV1", true);
        turret2.SetBool("TurretV1", true);
    }
    private void OnTriggerExit(Collider other)
    {

        turret1.SetBool("TurretV1", false);
        turret2.SetBool("TurretV1", false);
    }
}
