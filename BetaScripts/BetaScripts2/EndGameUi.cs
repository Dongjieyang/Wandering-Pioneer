using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameUi : MonoBehaviour
{
    public float currentTime = 0f;
    public TextMeshProUGUI minutesText,secondsText;
    public float minutes, seconds;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(seconds>=30)
        {
            minutes = (currentTime / 60)-1;
        }
        else
        {
            minutes = currentTime / 60;
        }

        seconds = currentTime % 60;
        minutesText.text = minutes.ToString("0");
        secondsText.text = seconds.ToString("0");
      

    }
}
