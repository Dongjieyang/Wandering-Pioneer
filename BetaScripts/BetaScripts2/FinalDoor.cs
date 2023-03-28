using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    public Animator finaldoor;
    public bool enterControlTower;
    public Component countDownScr;
    public GameObject mainCamera, finalCamera;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {


        finaldoor.SetBool("FinalDoorOpen", true);
        Invoke("Wait1", 3.0f);
        countDownScr.GetComponent<AlarmEscape>().isStart = false;
        countDownScr.GetComponent<AlarmEscape>().countUI.SetActive(false);
        mainCamera.SetActive(false);
        finalCamera.SetActive(true);
    }
    void Wait1()
    {
        finaldoor.SetBool("FinalDoorOpen", false);
    }
    private void OnTriggerExit(Collider other)
    {
        enterControlTower = true;


    }
}
