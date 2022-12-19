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
    public Transform startPlace;
    public Transform endPlace;
    public GameObject element;
    public Component console1;
    public Component console2;
    public GameObject door1;
    public GameObject door2;
    public GameObject corridor1;
    public GameObject corridor2;
    public GameObject corridor3;
    public Transform moveCorr;
    public Transform rotaCorr;
    public Transform rotaCorr2;
    public GameObject starter;




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
                player.transform.position = startPlace.transform.position;
                countUI.SetActive(false);
                element.SetActive(true);
                if (CollectUI.maxNun == 2)
                {
                    CollectUI.maxNun -= 1;
                }
                door1.SetActive(true);
                door2.SetActive(false);
                corridor1.transform.rotation = rotaCorr.transform.rotation;
                corridor2.transform.position = moveCorr.transform.position;
                corridor3.transform.rotation = rotaCorr2.transform.rotation;
                starter.SetActive(true);
                console1.GetComponent<ControlCorridor>().controlFirst = false;
                console1.GetComponent<ControlCorridor>().pressOnce = true;
                console2.GetComponent<ControlCorridor2>().controlFirst = false;
                console2.GetComponent<ControlCorridor2>().pressOnce = true;
                isStart = false;

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


}
