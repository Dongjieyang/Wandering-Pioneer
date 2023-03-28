using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public  float currentTime = 0f;
    public  float startingTime = 100f;
    public TextMeshProUGUI countdown;
    public GameObject countUI;
    public bool isStart = false;
    public GameObject player;
    public GameObject restartUi;
    public Transform startPlace;
    public Transform endPlace;
    public GameObject Npc;
    public Animator CorridorDoor1,CorridorDoor2, CorridorDoor3, CorridorRotate1, CorridorRotate2, CorridorMovement;
    public Component consoleRecover;
    public Component movementScript;



    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart == true)
        {
            currentTime -= Time.deltaTime;

            countdown.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = startingTime;
               
                countUI.SetActive(false);
                isStart = false;

                CorridorDoor1.SetBool("isCorridorDoor1Close", false);
                CorridorDoor2.SetBool("isCorridorDoor2Open", false);
                CorridorRotate1.SetBool("isCorridorRotate1Rot", false);
                CorridorRotate2.SetBool("isCorridorRotate2Rot", false);
                CorridorMovement.SetBool("isCorridorMove", false);
                CorridorDoor3.SetBool("isCorridorDoor3Open", false);
                Npc.SetActive(true);
                consoleRecover.GetComponent<SuggestiveUI>().enabled = true;
                consoleRecover.GetComponent<SuggestiveUI2>().enabled = false;
                restartUi.SetActive(true);
                Invoke("Wait1", 5.0f);
                movementScript.GetComponent<Movement>().enabled = false;


            }
            if(player.transform.position==endPlace.transform.position)
            {
                isStart = false;
                countUI.SetActive(false);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        countUI.SetActive(true);
        isStart = true;
    }
    void Wait1()
    {
        player.transform.position = startPlace.transform.position;
        restartUi.SetActive(false);
        movementScript.GetComponent<Movement>().enabled = true;
    }

}
