using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptManage : MonoBehaviour
{
    public GameObject promptParticle1, promptParticle2, promptParticle3, promptParticle4, promptParticle5, promptParticle6;
    bool once1,once2,once3,once4,once5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(promptParticle1.activeSelf==false&&once1==false)
        {
            promptParticle2.SetActive(true);
            once1 = true;
        }
        if (promptParticle2.activeSelf == false&& promptParticle1.activeSelf == false&&once2==false)
        {
            promptParticle3.SetActive(true);
            once2 = true;
        }
        if (promptParticle3.activeSelf == false&& promptParticle2.activeSelf == false && promptParticle1.activeSelf == false && once3 == false)
        {
            promptParticle4.SetActive(true);
            once3 = true;
        }
        if (promptParticle4.activeSelf == false&& promptParticle3.activeSelf == false && promptParticle2.activeSelf == false && promptParticle1.activeSelf == false && once4 == false)
        {
            promptParticle5.SetActive(true);
            once4 = true;
        }
        if (promptParticle5.activeSelf == false&& promptParticle4.activeSelf == false && promptParticle3.activeSelf == false && promptParticle2.activeSelf == false && promptParticle1.activeSelf == false && once5== false)
        {
            promptParticle6.SetActive(true);
            once5 = true;
        }
    }
}
