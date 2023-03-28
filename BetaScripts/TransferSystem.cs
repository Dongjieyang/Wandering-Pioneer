using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TransferSystem : MonoBehaviour
{
    public GameObject stuffMember,yourSelf, oldBody,oldBodyRoot, newBody;

    public GameObject progressUi;
    public float Progress;
    public Slider progressBar;
    public float inValue;
    public bool isProgress;
    public GameObject text1;
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
               

            }
        }
    }

    public void TransferToSystem()
    {
        isProgress = true;
        text1.gameObject.SetActive(true);
        progressUi.gameObject.SetActive(true);
        Invoke("Wait1", 6);
    }

    void Wait1()
    {
        stuffMember.gameObject.SetActive(false);
        yourSelf.gameObject.SetActive(true);
        oldBody.gameObject.SetActive(false);
        newBody.gameObject.SetActive(true);
    }
}
