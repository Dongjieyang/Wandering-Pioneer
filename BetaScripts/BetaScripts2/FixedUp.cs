using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUp : MonoBehaviour
{
    public Component wallFan;
    public Component checkInfo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemUse.Instance.fixedUp==true)
        {
            wallFan.GetComponent<Animation>().enabled = true;
            wallFan.GetComponent<AudioSource>().enabled = true;
            checkInfo.GetComponent<SuggestiveUI>().enabled = false;
            checkInfo.GetComponent<SuggestiveUI2>().enabled = true;

        }
    }
}
