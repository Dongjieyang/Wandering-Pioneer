 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public Toggle EnableRemove;

    public InventroyItemController[] InventoryItems;


    private void Awake()
    {
        Instance = this;
    }
    public  void Add(Item item)
    {
        Items.Add(item);
    }
    public void Remove(Item item)
    {
        Items.Remove(item);
    }
    public void ListItems()
    {
        foreach(Transform item in ItemContent)
        {
            item.gameObject.SetActive(false);
        }
        foreach(var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("itemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("itemIcon").GetComponent<Image>();
            var removeButton = obj.transform.Find("removebutton").GetComponent<Button>();

            itemName.text = item.ItemName;
            itemIcon.sprite = item.icon;

            if(EnableRemove.isOn)
            {
                removeButton.gameObject.SetActive(true);
            }
        }

        SetInventoryItem();
    }

    

    public void EnableItemRemove()
    {
        if(EnableRemove.isOn)
        {
            foreach (Transform item in ItemContent)
            {
                item.Find("removebutton").gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (Transform item in ItemContent)
            {
                item.Find("removebutton").gameObject.SetActive(false);
            }
        }
        
    }
    public void CloseRemoveButton()
    {
        EnableRemove.isOn = false;
    }

    public void SetInventoryItem()
    {
        InventoryItems = ItemContent.GetComponentsInChildren<InventroyItemController>();

        for (int i = 0; i < Items.Count; i++)
        {
            InventoryItems[i].AddItem(Items[i]);
        }
    }
}
