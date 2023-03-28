using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureDoorClose : MonoBehaviour
{
    public float throughtNum = 1;
    public Animator Door;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (throughtNum % 3 == 0)
        {
            Invoke("Wait1", 1.5f);

        }

        if (throughtNum >= 3)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            throughtNum = 1;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        throughtNum++;

    }


    void Wait1()
    {
        Door.SetBool("isOpening", false);
    }
}
