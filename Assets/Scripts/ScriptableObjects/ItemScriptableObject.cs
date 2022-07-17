using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType { Default, Food, Weapon, Instrument }

public class ItemScriptableObject : ScriptableObject
{
    public GameObject itemPrefab;
    public Sprite icon;

    public ItemType itemType;

    public string itemName;
    public string itemDiscription;

    public int maxAmount;
}
