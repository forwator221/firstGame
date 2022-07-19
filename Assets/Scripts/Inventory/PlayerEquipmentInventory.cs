using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipmentInventory : MonoBehaviour
{
    public ItemSlotManager itemSlotManager;

    public ItemScriptableObject rightWeapon;
    public ItemScriptableObject leftWeapon;
    public ItemScriptableObject helmet;

    private void Awake()
    {
        itemSlotManager = GetComponent<ItemSlotManager>();
    }

    private void Start()
    {

    }
}
