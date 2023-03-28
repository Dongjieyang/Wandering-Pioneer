using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventroyItemController : MonoBehaviour
{
    public Item item;

    public Button RemoveButton;
    public static InventroyItemController Instance;


    private void Awake()
    {
        Instance = this;
    }
    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        Destroy(gameObject);
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
    }
   
    public void UseItem()
    {
        switch(item.itemType)
        {
            case Item.ItemType.Starter:
                 ItemUse.Instance.Teleport();
                if (ItemUse.Instance.portal.gameObject.GetComponent<Arrived>().arrived == true)
                {
                    RemoveItem();
                }
                break;
            case Item.ItemType.Starter2:
                ItemUse.Instance.Teleport2();
                if (ItemUse.Instance.portal2.gameObject.GetComponent<Arrived>().arrived == true)
                {
                    RemoveItem();
                }
                break;
            case Item.ItemType.Starter3:
                ItemUse.Instance.Teleport3();
                if (ItemUse.Instance.portal3.gameObject.GetComponent<Arrived>().arrived == true)
                {
                    RemoveItem();
                }
                break;

            case Item.ItemType.Prop:
                ItemUse.Instance.NotInTradeArea();
                if (ItemUse.Instance.tradeBuilding.gameObject.GetComponent<Arrived>().arrived == true)
                {
                    ItemUse.Instance.Trade();
                    RemoveItem();                
                }
                break;

            case Item.ItemType.Prop_useless:
                ItemUse.Instance.UselessProps();
                break;

            case Item.ItemType.Tool:
                ItemUse.Instance.UseTool1();
                if (ItemUse.Instance.circuitBoards1.gameObject.GetComponent<Arrived>().arrived == true)
                {
                    RemoveItem();
                }
                break;

            case Item.ItemType.Tool2:
                if (ItemUse.Instance.circuitBoards1.gameObject.GetComponent<Arrived>().arrived == true&&ItemUse.Instance.usedTool1==true)
                {
                    RemoveItem();
                    ItemUse.Instance.UseTool2();
                }
                else if(ItemUse.Instance.circuitBoards1.gameObject.GetComponent<Arrived>().arrived == true && ItemUse.Instance.usedTool1 == false)
                {
                    ItemUse.Instance.UseTool1First();
                }
                else
                {
                    ItemUse.Instance.UseTool2();
                }
                break;

            case Item.ItemType.Tool3:
                ItemUse.Instance.AddGroundTile();
                if (ItemUse.Instance.bridge.gameObject.GetComponent<Arrived>().arrived == true)
                {
                    RemoveItem();
                    
                }
                break;

            case Item.ItemType.Tool_useless:
                ItemUse.Instance.UselessProps();
                break;

        }
       

    }

    

}
