using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Component teleCollider;
    public Transform player;
    public Transform destination;
    public bool gotStarter=false;
    public Component collectStarter;

   void Update()
    {
        gotStarter = collectStarter.GetComponent<CollectStarter>().gotStarter;

        if (gotStarter == true)
        {
            teleCollider.GetComponent<BoxCollider>().enabled = true;
        }
    }
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.E))
        {
            teleCollider.GetComponent<BoxCollider>().enabled = true;
            player.transform.position = destination.transform.position;
        }

       
    }
}
