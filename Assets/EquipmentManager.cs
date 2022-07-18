using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region Singleton
    public static EquipmentManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    EquipmentObject[] currentEquipment;

    Inventory inventory;

    private void Start()
    {
        inventory = Inventory.instance;

        int numberOfSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new EquipmentObject[numberOfSlots];
    }

    public void Equip(EquipmentObject newItem)
    {
        int slotIndex = (int)newItem.equipmentSlot;

        EquipmentObject oldItem = null;

        if (currentEquipment[slotIndex] != null)
        {
            oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);
        }

        currentEquipment[slotIndex] = newItem;
    }

    public void Unequip(int slotIndex)
    {
        if (currentEquipment[slotIndex] != null)
        {
            EquipmentObject oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);

            currentEquipment[slotIndex] = null;
        }
    }

    public void UnequipAll()
    {
        for (int i = 0; i < currentEquipment.Length; i++)
        {
            Unequip(i);
        }
    }
}
