using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemUse : MonoBehaviour
{
    public static ItemUse Instance;

    public Transform player;
    public Transform destination1,destination2,destination3;
    public GameObject portal,portal2,portal3,tradeBuilding, circuitBoards1,bridge;
    public GameObject ItemUseUI,ItemUseless,ItemUseFirst;
    public GameObject Inventory;
    public GameObject stater;
    float count = 0;

    public GameObject progressUi;
    public float Progress;
    public Slider progressBar;
    public float inValue;
    public bool isProgress;
    public bool usedTool1;
    public bool fixedUp;

    public GameObject text1, text2, text3;

    public GameObject groundTile1, groundTile2, groundTile3;

    private void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        if(isProgress==true)
        {
            progressBar.value = Progress;
            Progress += inValue * Time.deltaTime;
            if(Progress>=progressBar.maxValue)
            {
                Progress = 0;
                isProgress = false;
                progressUi.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

            }
        }
       
    }


    public  void Teleport()
    {
        if (portal.gameObject.GetComponent<Arrived>().arrived == true)
        {
            player.transform.position = destination1.transform.position;
            Inventory.gameObject.SetActive(false);

        }
        else if(portal.gameObject.GetComponent<Arrived>().arrived == false)
        {
            ItemUseUI.gameObject.SetActive(true);
            Invoke("Wait1", 3);
        }
    }
    public void Teleport2()
    {
        if (portal2.gameObject.GetComponent<Arrived>().arrived == true)
        {
            player.transform.position = destination2.transform.position;
            Inventory.gameObject.SetActive(false);

        }
        else if (portal2.gameObject.GetComponent<Arrived>().arrived == false)
        {
            ItemUseUI.gameObject.SetActive(true);
            Invoke("Wait1", 3);
        }
    }
    public void Teleport3()
    {
        if (portal3.gameObject.GetComponent<Arrived>().arrived == true)
        {
            player.transform.position = destination3.transform.position;
            Inventory.gameObject.SetActive(false);

        }
        else if (portal3.gameObject.GetComponent<Arrived>().arrived == false)
        {
            ItemUseUI.gameObject.SetActive(true);
            Invoke("Wait1", 3);
        }
    }

    public void Trade()
    {
        count++;
        if (count >=2)
        {
            stater.gameObject.SetActive(true);

        }
    }

    public void NotInTradeArea()
    {
        if (tradeBuilding.gameObject.GetComponent<Arrived>().arrived == false)
        {
            ItemUseUI.gameObject.SetActive(true);
            Invoke("Wait1", 3);
        }
    }

    public void UselessProps()
    {
        ItemUseless.gameObject.SetActive(true);
        Invoke("Wait2", 3);
    }


    public void UseTool1()
    {
        if (circuitBoards1.gameObject.GetComponent<Arrived>().arrived == true)
        {

            progressUi.gameObject.SetActive(true);
            isProgress = true;
            usedTool1 = true;
            text1.gameObject.SetActive(true);
            
           
        }
        else if (circuitBoards1.gameObject.GetComponent<Arrived>().arrived == false)
        {
            ItemUseUI.gameObject.SetActive(true);
            Invoke("Wait1", 3);
        }
    }

    public void UseTool2()
    {
        if (circuitBoards1.gameObject.GetComponent<Arrived>().arrived == true)
        {

            progressUi.gameObject.SetActive(true);
            isProgress = true;
            Invoke("Wait4", 5);
            text2.gameObject.SetActive(true);

        }
        else if (circuitBoards1.gameObject.GetComponent<Arrived>().arrived == false)
        {
            ItemUseUI.gameObject.SetActive(true);
            Invoke("Wait1", 3);
        }
    }


    public void UseTool1First()
    {
        ItemUseFirst.gameObject.SetActive(true);
        Invoke("Wait3", 3);
    }

    public void AddGroundTile()
    {
        if (bridge.gameObject.GetComponent<Arrived>().arrived == true)
        {

            progressUi.gameObject.SetActive(true);
            isProgress = true;
            Invoke("Wait5", 5);
            text3.gameObject.SetActive(true);
        }
        else if (bridge.gameObject.GetComponent<Arrived>().arrived == false)
        {
            ItemUseUI.gameObject.SetActive(true);
            Invoke("Wait1", 3);
        }
    }





    void Wait1()
    {
        ItemUseUI.gameObject.SetActive(false);
    }
    void Wait2()
    {
        ItemUseless.gameObject.SetActive(false);
    }
    void Wait3()
    {
        ItemUseFirst.gameObject.SetActive(false);
    }

    void Wait4()
    {
        fixedUp = true;
    }
    void Wait5()
    {
        if (groundTile1.gameObject.activeSelf == false)
        {
            groundTile1.gameObject.SetActive(true);
        }
        else if(groundTile1.gameObject.activeSelf == true && groundTile2.gameObject.activeSelf == false)
        {
            groundTile2.gameObject.SetActive(true);
        }
        else if (groundTile2.gameObject.activeSelf == true&& groundTile1.gameObject.activeSelf == true)
        {
            groundTile3.gameObject.SetActive(true);
        }

    }
}
