using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : Interactable
{
    public ItemScriptableObject item;
    public int amount;

    public override void Interact(PlayerManager playerManager)
    {
        base.Interact(playerManager);

        PickUp();
    }

    public void PickUp()
    {
        Debug.Log("picking up" + item.itemName);
        Inventory.instance.Add(item);
        Destroy(gameObject);
    }
}
