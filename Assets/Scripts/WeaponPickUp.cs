using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : Interactable
{
    public WeaponItem weapon;

    public override void Interact(PlayerManager playerManager)
    {
        Debug.Log("You interracted");

        PickUpItem(playerManager);
    }

    private void PickUpItem(PlayerManager playerManager)
    {
        PlayerInventory playerInventory;
        PlayerLokomotion playerLokomotion;
        playerInventory = playerManager.GetComponent<PlayerInventory>();
        playerLokomotion = playerManager.GetComponent<PlayerLokomotion>();

        playerLokomotion.playerRigitbody.velocity = Vector3.zero;
        playerInventory.weaponInventory.Add(weapon);
        Destroy(gameObject);
    }
}
