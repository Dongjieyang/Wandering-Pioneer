using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlarmEscape : MonoBehaviour
{
    public Component alarmLight;
    public float intensityChange;
    public bool lightOn;
    public bool triggerOnce;
    bool increseIntensity = true;
    public GameObject text;
    public GameObject elementD;

    public float currentTime = 0f;
    public float startingTime = 100f;
    public TextMeshProUGUI countdown;
    public GameObject countUI;
    public bool isStart = false;
    public GameObject player;
    public GameObject restartUi;
    public Transform startPlace;
    public Component movementScript;

    public GameObject reStartUi2;
    public GameObject waitUi;


    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (lightOn)
        {
            if (alarmLight.GetComponent<Light>().intensity < 1000 && increseIntensity == true)
            {
                alarmLight.GetComponent<Light>().intensity += intensityChange;
            }

            if (alarmLight.GetComponent<Light>().intensity > 500 && increseIntensity == false)
            {
                alarmLight.GetComponent<Light>().intensity -= intensityChange;
            }
            if (alarmLight.GetComponent<Light>().intensity >= 1000)
            {
                increseIntensity = false;
            }
            if (alarmLight.GetComponent<Light>().intensity <= 500)
            {
                increseIntensity = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            text.SetActive(false);
        }

        if (elementD.activeSelf==false&&triggerOnce==false)
        {
            alarmLight.GetComponent<Light>().enabled = true;
            lightOn = true;
            text.SetActive(true);
            isStart = true;
            countUI.SetActive(true);
            triggerOnce = true;

        }

        if (isStart == true)
        {
            currentTime -= Time.deltaTime;

            countdown.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = startingTime;

                countUI.SetActive(false);
                isStart = false;
                restartUi.SetActive(true);
                Invoke("Wait2", 5.0f);
                movementScript.GetComponent<Movement>().enabled = false;
                lightOn = false;
                alarmLight.GetComponent<Light>().enabled = false;

            }
           
        }

    }
    void Wait2()
    {
        player.transform.position = startPlace.transform.position;
        restartUi.SetActive(false);
        reStartUi2.SetActive(true);

    }
    void Wait3()
    {
        reStartUi2.SetActive(true);
        waitUi.SetActive(false);
    }
    public void ReStart()
    {
        movementScript.GetComponent<Movement>().enabled = true;
        alarmLight.GetComponent<Light>().enabled = true;
        lightOn = true;
        Invoke("Wait1", 60.0f);
        text.SetActive(true);
        isStart = true;
        countUI.SetActive(true);
    }

    public void WaitMints()
    {
        Invoke("Wait3", 10.0f);
        waitUi.SetActive(true);

    }
}
