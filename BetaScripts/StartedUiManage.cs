using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartedUiManage : MonoBehaviour
{
    public GameObject Ui1;

    private Image UiImage;
    private Color newUiColor;
    public float TransparentNn;
    public GameObject text1, text2, pic1, pic2, pic3, pic4;

    public bool istarted;
    void Start()
    {
        UiImage = Ui1.GetComponent<Image>();
        Invoke("Wait1", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Ui1.activeSelf == true&&istarted)
        {
            if (TransparentNn <=1&&TransparentNn>0 )
            {
                TransparentNn -= 0.1f*Time.deltaTime;
               

            }
            else if (TransparentNn<=0)
            {
                TransparentNn = 0;
                Ui1.gameObject.SetActive(false);
            }



            newUiColor = new Color(0, 0, 0, TransparentNn);

            UiImage.color = newUiColor;
        }
    }
    void Wait1()
    {
        text1.gameObject.SetActive(true);
        Invoke("Wait2", 5.0f);
    }
    void Wait2()
    {
        text2.gameObject.SetActive(true);
        pic1.gameObject.SetActive(true);
        pic2.gameObject.SetActive(true);
        pic3.gameObject.SetActive(true);
        pic4.gameObject.SetActive(true);
        Invoke("Wait3", 5.0f);

    }
    void Wait3()
    {
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        pic1.gameObject.SetActive(false);
        pic2.gameObject.SetActive(false);
        pic3.gameObject.SetActive(false);
        pic4.gameObject.SetActive(false);
        Invoke("Wait4", 2.0f);
    }
    void Wait4()
    {
        istarted = true;
    }

}
