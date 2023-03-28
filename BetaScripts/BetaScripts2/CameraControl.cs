using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject MainCamera, Camera1, Camera2, Camera3,Camera4,Camera5;

    public bool cancelFixed;
    public bool restartV2=true;

    public GameObject sparks1, sparks2, sparks3;
    public GameObject v2Screen;

    private void Update()
    {
        if(ItemUse.Instance.fixedUp == true&&cancelFixed==false)
        {
            Camera4.gameObject.SetActive(true);
            MainCamera.gameObject.SetActive(false);
            Invoke("Wait3", 3.0f);
        }

        if(v2Screen.gameObject.activeSelf==false&&restartV2)
        {
            MainCamera.gameObject.SetActive(false);
            Camera5.gameObject.SetActive(true);
            Invoke("Wait4", 2.0f);
        }
    }

    public void FirstCamera()
    {
        MainCamera.gameObject.SetActive(false);
        Camera1.gameObject.SetActive(true);
        Invoke("Wait1", 2.0f);
    }
    public void SecondCamera()
    {
        MainCamera.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(true);
        Camera3.gameObject.SetActive(true);
        Invoke("Wait2", 2.0f);
    }






    void Wait1()
    {
        MainCamera.gameObject.SetActive(true);
        Camera1.gameObject.SetActive(false);

    }
    void Wait2()
    {
        MainCamera.gameObject.SetActive(true);
        Camera2.gameObject.SetActive(false);
        Camera3.gameObject.SetActive(false);

    }
    void Wait3()
    {
        MainCamera.gameObject.SetActive(true);
        Camera4.gameObject.SetActive(false);
        cancelFixed = true;
        sparks1.gameObject.SetActive(false);
        sparks2.gameObject.SetActive(false);
        sparks3.gameObject.SetActive(false);
    }
    void Wait4()
    {
        MainCamera.gameObject.SetActive(true);
        Camera5.gameObject.SetActive(false);
        restartV2 = false;

    }
}
