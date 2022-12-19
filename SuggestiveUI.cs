using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuggestiveUI : MonoBehaviour
{
    public GameObject text;
    public GameObject prompt;
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.F))
        {
           text.SetActive(true);
            Invoke("Wait", 5);
        }


    }

  void Wait()
    {
        text.SetActive(false);
        prompt.SetActive(false);
    }
}
