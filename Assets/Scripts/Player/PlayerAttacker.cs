using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    AnimatorManager animatorManager;
    //PlayerInventory playerInventory;
    WeaponSlotManager weaponSlotManager;

    //private int lefthandIndex;
    //private int rightHandIndex;

    //private bool isUnarmed;

    private void Awake()
    {
        animatorManager = GetComponentInChildren<AnimatorManager>();
        weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        //playerInventory = GetComponent<PlayerInventory>();
    }

    //private void FixedUpdate()
    //{
    //    CheckIndex();
    //}

    public void HandleLightAttack(WeaponItem weapon)
    {
        weaponSlotManager.attackingWeapon = weapon;
        animatorManager.PlayTargetAnimation(weapon.OH_Light_Attack_01, true);
        //if (isUnarmed)
        //{          
        //    animatorManager.PlayTargetAnimation(weapon.Unarmed_Attack_R01, true);
        //}
        //else
        //{
        //    animatorManager.PlayTargetAnimation(weapon.OH_Light_Attack_01, true);
        //}
    }

    public void HandleComboLightAttack(WeaponItem weapon)
    {
        weaponSlotManager.attackingWeapon = weapon;
        animatorManager.PlayTargetAnimation(weapon.OH_Combo_Light_Attack_01, true);
    }

    //private void CheckIndex()
    //{
    //    rightHandIndex = playerInventory.currentRightWeaponIndex;
    //    lefthandIndex = playerInventory.currentLeftWeaponIndex;

    //    if (rightHandIndex == -1 && lefthandIndex == -1)
    //    {
    //        isUnarmed = true;
    //    }
    //    else
    //    {
    //        isUnarmed = false;
    //    }           
    //}

}
