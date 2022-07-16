using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Weapon Item")]
public class WeaponItem : Item
{
    public GameObject modelPrefab;
    public bool isUnarmed;

    [Header("Idle Animations")]
    public string Right_Hand_Idle;
    public string Left_Hand_Idle;

    [Header("Unarmed Attack Animations")]
    public string Unarmed_Attack_L01;
    public string Unarmed_Attack_R01;

    [Header("One Handed Attack Animations")]
    public string OH_Light_Attack_01;
    public string OH_Combo_Light_Attack_01;

    [Header("Stamina Costs")]
    public int baseStamina;
    public float lightAttackMultiplier;
    public float comboAttackMultiplier;
}
