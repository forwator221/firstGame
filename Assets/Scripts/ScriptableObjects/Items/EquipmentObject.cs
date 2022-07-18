using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Items/new equipment item")]

public class EquipmentObject : ItemScriptableObject
{

    public EquipmentSlot equipmentSlot;

    public int damageModifier;
    public int armorModifier;

    public override void Use()
    {
        base.Use();

        EquipmentManager.instance.Equip(this);
        RemoveFromInventory();
    }

}

public enum EquipmentSlot { Head, Chest, Legs, RightHand, LeftHand, Feet}