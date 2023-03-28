using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElementDoorPassWord : MonoBehaviour
{
    public GameObject Ui1, Ui2;
    public Animator DoorOpen;

    string Code = "154";
    string Nr = null;
    int NrIndex = 0;
    public TextMeshProUGUI UiText=null;

    public void PassCode(string numbers)
    {
        if (NrIndex < 3)
        {
            NrIndex++;
            Nr = Nr + numbers;
            UiText.text = Nr;
        }
    }
    
    public void Enter()
    {
        if(Nr==Code)
        {
            Ui1.gameObject.SetActive(true);
            Invoke("Wait1", 2f);
            NrIndex = 0;
            Nr = null;
            UiText.text = Nr;
        }
        else
        {
            Ui2.gameObject.SetActive(true);
            Invoke("Wait2", 2f);
            NrIndex = 0;
            Nr = null;
            UiText.text = Nr;
        }
    }
    public void Delete()
    {
        NrIndex = 0; 
        Nr = null;
        UiText.text = Nr;
        
    }
    private void Update()
    {
        if(NrIndex>=3)
        {
            NrIndex = 3;
        }
    }
    void Wait1()
    {
        Ui1.gameObject.SetActive(false);
        DoorOpen.SetBool("ElementDoorOpen", true);
    }
    void Wait2()
    {
        Ui2.gameObject.SetActive(false);
    }
}
