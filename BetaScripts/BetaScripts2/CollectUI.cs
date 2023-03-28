using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectUI : MonoBehaviour
{
    public GameObject crystal1, crystal2, crystal3, crystal4;
    public static int maxNun;
    void Start()
    {
        maxNun = 0;
        crystal1.gameObject.SetActive(false);
        crystal2.gameObject.SetActive(false);
        crystal3.gameObject.SetActive(false);
        crystal4.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (maxNun > 4)
            maxNun = 4;
        switch (maxNun)
        {
            case 4:
                crystal1.gameObject.SetActive(true);
                crystal2.gameObject.SetActive(true);
                crystal3.gameObject.SetActive(true);
                crystal4.gameObject.SetActive(true);
                break;
            case 3:
                crystal1.gameObject.SetActive(true);
                crystal2.gameObject.SetActive(true);
                crystal3.gameObject.SetActive(true);
                crystal4.gameObject.SetActive(false);
                break;
            case 2:
                crystal1.gameObject.SetActive(true);
                crystal2.gameObject.SetActive(true);
                crystal3.gameObject.SetActive(false);
                crystal4.gameObject.SetActive(false);
                break;
            case 1:
                crystal1.gameObject.SetActive(true);
                crystal2.gameObject.SetActive(false);
                crystal3.gameObject.SetActive(false);
                crystal4.gameObject.SetActive(false);
                break;
            case 0:
                crystal1.gameObject.SetActive(false);
                crystal2.gameObject.SetActive(false);
                crystal3.gameObject.SetActive(false);
                crystal4.gameObject.SetActive(false);
                break;


        }
    }
}
