using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType { Default, Food, Weapon, Armor, Instrument }

public class ItemScriptableObject : ScriptableObject
{
    public GameObject itemPrefab;
    public Sprite icon;

    public string itemName;
    public string itemDiscription;

    public int maxAmount;

    public ItemType itemType;

    public virtual void Use()
    {
        Debug.Log("Using" + itemName);
    }

    public virtual void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
