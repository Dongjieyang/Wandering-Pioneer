using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmControl : MonoBehaviour
{
    public GameObject Ui1;
    public Component alarmLight;
    public float intensityChange;
    public bool lightOn;
    bool increseIntensity = true;
    public Animator brDoor;
    public GameObject text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lightOn)
        {
            if (alarmLight.GetComponent<Light>().intensity < 100&&increseIntensity==true)
            {
                alarmLight.GetComponent<Light>().intensity += intensityChange;
            }

            if (alarmLight.GetComponent<Light>().intensity > 50&&increseIntensity==false)
            {
                alarmLight.GetComponent<Light>().intensity -= intensityChange ;
            }
            if(alarmLight.GetComponent<Light>().intensity>=100)
            {
                increseIntensity = false;
            }
            if (alarmLight.GetComponent<Light>().intensity <=50)
            {
                increseIntensity =true;
            }
        }


        if (Input.GetKeyDown(KeyCode.F) )
        {
            text.SetActive(false);
        }
    }
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            alarmLight.GetComponent<Light>().enabled = true;
            lightOn = true;
            Invoke("Wait1", 15.0f);
            brDoor.SetBool("BRDopen",false);
            text.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Ui1.gameObject.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        Ui1.gameObject.SetActive(false);

    }
    void Wait1()
    {
        lightOn = false;
        alarmLight.GetComponent<Light>().enabled = false;
        brDoor.SetBool("BRDopen", true);
    }
}
