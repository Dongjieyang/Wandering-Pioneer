using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject Player;
    private float OriginalMouseSpeed;
    void Start()
    {
        OriginalMouseSpeed = Player.gameObject.GetComponent<Movement>().mouseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetMouseButtonDown(1))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Player.gameObject.GetComponent<Movement>().mouseSpeed = OriginalMouseSpeed;
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            Cursor.lockState = CursorLockMode.Confined;
            Player.gameObject.GetComponent<Movement>().mouseSpeed = 0;
        }

    }
}
