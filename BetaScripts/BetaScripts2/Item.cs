using UnityEngine;

[CreateAssetMenu(fileName ="New Item",menuName ="Item/Create New Item")]

public class Item : ScriptableObject
{
    public int id;
    public string ItemName;
    public Sprite icon;
    public ItemType itemType;

   public enum ItemType
   { 
      Starter,
      Starter2,
      Tool,
      Prop,
      Element,
      ElementB,
      Prop_useless,
      Tool2,
      Tool_useless,
      Starter3,
      Tool3,
      ElementC,
      ElementD,
    }
}