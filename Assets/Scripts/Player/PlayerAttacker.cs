using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    AnimatorManager animatorManager;
    //WeaponSlotManager weaponSlotManager;

    private void Awake()
    {
        animatorManager = GetComponentInChildren<AnimatorManager>();
    }
    //public void HandleLightAttack(WeaponItem weapon)
    //{
    //    weaponSlotManager.attackingWeapon = weapon;
    //    animatorManager.PlayTargetAnimation(weapon.OH_Light_Attack_01, true);
    //}

    //public void HandleComboLightAttack(WeaponItem weapon)
    //{
    //    weaponSlotManager.attackingWeapon = weapon;
    //    animatorManager.PlayTargetAnimation(weapon.OH_Combo_Light_Attack_01, true);
    //}
}
