using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;
    public GameObject Ui1;

    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        InventoryManager.Instance.ListItems();
        gameObject.SetActive(false);
        Ui1.gameObject.SetActive(false);
    }

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Pickup();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Ui1.gameObject.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        Ui1.gameObject.SetActive(false);

    }


}
