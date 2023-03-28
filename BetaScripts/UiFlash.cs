using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiFlash : MonoBehaviour
{
    public GameObject Ui1;

    private Image UiImage;
    private Color newUiColor;
    public float TransparentNn;
    bool increseTrans=true;
    void Start()
    {
        UiImage = Ui1.GetComponent<Image>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Ui1.activeSelf==true)
        {
           if(TransparentNn<1&&increseTrans==true)
            {
                TransparentNn += 1.0f*Time.deltaTime;

            }
            if (TransparentNn > 0.1&&increseTrans==false)
            {
                TransparentNn -= 1.0f * Time.deltaTime;
            }
            if(TransparentNn>=1)
            {
                increseTrans = false;
            }
            if (TransparentNn <= 0.1f)
            {
                increseTrans = true;
            }


            newUiColor = new Color(1, 1, 1, TransparentNn);

            UiImage.color = newUiColor;
        }
    }


}
