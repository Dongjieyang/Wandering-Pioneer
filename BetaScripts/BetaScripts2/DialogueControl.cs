using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueControl : MonoBehaviour
{
    public Component suggesUI, suggesUI2, suggesUI3, suggesUI4, suggesUI5, suggesUI6, suggesUI7, suggesUI8
        ;
    public GameObject stuffBody;
    public Component countDownTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemUse.Instance.fixedUp==true)
        {
            suggesUI6.GetComponent<SuggestiveUI>().enabled = false;
            suggesUI6.GetComponent<SuggestiveUI2>().enabled = true;
        }

        if(stuffBody.gameObject.activeSelf==false)
        {
            suggesUI8.GetComponent<SuggestiveUI>().enabled = false;
            suggesUI8.GetComponent<SuggestiveUI2>().enabled = true;
            
        }
    }

    public void GotTask()
    {
        suggesUI.GetComponent<SuggestiveUI>().enabled = false;
        suggesUI.GetComponent<SuggestiveUI2>().enabled = true;
        suggesUI2.GetComponent<SuggestiveUI>().enabled = false;
        suggesUI2.GetComponent<SuggestiveUI2>().enabled = true;
        suggesUI3.GetComponent<SuggestiveUI>().enabled = false;
        suggesUI3.GetComponent<SuggestiveUI2>().enabled = true;
    }

    public void GotStarter()
    {
        suggesUI4.GetComponent<SuggestiveUI>().enabled = false;
        suggesUI4.GetComponent<SuggestiveUI2>().enabled = true;
    }

    public void OperateInitailConsole()
    {
        suggesUI5.GetComponent<SuggestiveUI>().enabled = false;
        suggesUI5.GetComponent<SuggestiveUI2>().enabled = true;
    }

    public void DecreaseCountDownTime()
    {
        countDownTime.GetComponent<CountDown>().currentTime= countDownTime.GetComponent<CountDown>().currentTime - 15.0f;
    }

    public void V2Generator()
    {
        suggesUI7.GetComponent<SuggestiveUI>().enabled = false;
        suggesUI7.GetComponent<SuggestiveUI2>().enabled = true;
    }

}
