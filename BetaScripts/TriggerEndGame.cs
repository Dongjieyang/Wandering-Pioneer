using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEndGame : MonoBehaviour
{
    public GameObject endGameUi;
    public GameObject bgm,bgmEnd;
   

    private void OnTriggerEnter(Collider other)
    {
        endGameUi.gameObject.SetActive(true);
        Time.timeScale = 0f;
        bgm.SetActive(false);
        bgmEnd.SetActive(true);

    }
}
