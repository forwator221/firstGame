using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    AnimatorManager animatorManager;

    private void Awake()
    {
        animatorManager = GetComponentInChildren<AnimatorManager>();
    }

    public void HandleLightAttack(WeaponItem weapon)
    {
        animatorManager.PlayTargetAnimation(weapon.OH_Light_Attack_1, true);
    }

    public void HandleComboLightAttack(WeaponItem weapon)
    {
        animatorManager.PlayTargetAnimation(weapon.OH_Combo_Light_Attack_1, true);
    }
}
