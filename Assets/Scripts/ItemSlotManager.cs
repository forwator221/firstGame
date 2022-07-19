using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlotManager : MonoBehaviour
{
    ItemHolderSlot slot;

    private void Awake()
    {
        ItemHolderSlot[] itemHolderSlots = GetComponentsInChildren<ItemHolderSlot>();
        foreach (ItemHolderSlot itemSlot in itemHolderSlots)
        {
            slot = itemSlot;
        }
    }

    public void LoadItemOnSlot(ItemScriptableObject item)
    {
        slot.LoadItemModel(item);
    }
}
