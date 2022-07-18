using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Items/new equipment item")]

public class EquipmentObject : ItemScriptableObject
{

    public EquipmentSlot armorSlot;

    public int damageModifier;
    public int armorModifier;

}

public enum EquipmentSlot { Head, Chest, Legs, RightHand, LeftHand, Feet}