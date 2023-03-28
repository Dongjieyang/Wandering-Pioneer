using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public GameObject Npc;
    public Animator TankDoor,WorkshopDoor,TeleportRamp,CorridorDoor2, CorridorDoor3,CorridorRotate1, CorridorRotate2,CorridorMovement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TankDoorOpen()
    {
        TankDoor.SetBool("isTankDoorOpen", true);
    }
    public void WorkShopDoorOpen()
    {
        WorkshopDoor.SetBool("isOpening", true);
    }
    public void TeleportRampDropDown()
    {
       TeleportRamp.SetBool("hadStarter", true);
    }

    public void CorridorDoor2Open()
    {

        CorridorDoor2.SetBool("isCorridorDoor2Open", true);
    }

    public void CorridorRotate1Rot()
    {
        CorridorRotate1.SetBool("isCorridorRotate1Rot", true);
    }
    public void CorridorRotate2Rot()
    {
        CorridorRotate2.SetBool("isCorridorRotate2Rot", true);
    }

    public void CorridorMove()
    {
        CorridorMovement.SetBool("isCorridorMove", true);
    }
    public void CorridorRotate2RotBack()
    {
        CorridorRotate2.SetBool("isCorridorRotate2Rot", false);
    }

    public void CorridorDoor3Open()
    {
        CorridorDoor3.SetBool("isCorridorDoor3Open", true);
        Npc.gameObject.SetActive(false);
    }
}
