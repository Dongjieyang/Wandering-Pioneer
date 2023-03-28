using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolController : MonoBehaviour
{
    public GameObject Tool1, Tool2, Tool3;



    public void GotCollider()
    {
        Tool1.gameObject.GetComponent<BoxCollider>().enabled = true;
        Tool2.gameObject.GetComponent<BoxCollider>().enabled = true;
        Tool3.gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
