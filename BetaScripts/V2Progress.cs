using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class V2Progress : MonoBehaviour
{
    public GameObject progressUi;
    public float Progress;
    public Slider progressBar;
    public float inValue;
    public bool isProgress;
    public GameObject text1, text2;
    public GameObject screen;
    public Component workingAnimation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isProgress == true)
        {
            progressBar.value = Progress;
            Progress += inValue * Time.deltaTime;
            if (Progress >= progressBar.maxValue)
            {
                Progress = 0;
                isProgress = false;
                progressUi.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

            }
        }
    }

    public void CheckingV2()
    {
        isProgress = true;
        text1.gameObject.SetActive(true);
        progressUi.gameObject.SetActive(true);
    }
    public void ReStartV2()
    {
        isProgress = true;
        text2.gameObject.SetActive(true);
        progressUi.gameObject.SetActive(true);
        Invoke("Wait1", 6);
    }

    void Wait1()
    {
        screen.gameObject.SetActive(false);
        workingAnimation.GetComponent<Animation>().enabled = true;
    }
}
