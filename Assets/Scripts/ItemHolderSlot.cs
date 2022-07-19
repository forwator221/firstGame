using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolderSlot : MonoBehaviour
{
    public Transform parentOverride;

    public GameObject currentItemModel;

    public void UnloadWeapon()
    {
        if (currentItemModel != null)
        {
            currentItemModel.SetActive(false);
        }
    }

    public void UnloadWeaponAndDestroy()
    {
        if (currentItemModel != null)
        {
            Destroy(currentItemModel);
        }
    }
    
    public void LoadItemModel(ItemScriptableObject item)
    {
        UnloadWeaponAndDestroy();

        if (item == null)
        {
            UnloadWeapon();
            return;
        }

        GameObject model = Instantiate(item.itemPrefab) as GameObject;
        if(model != null)
        {
            if(parentOverride != null)
            {
                model.transform.parent = parentOverride;
            }
            else
            {
                model.transform.parent = transform;
            }

            model.transform.localPosition = Vector3.zero;
            model.transform.localRotation = Quaternion.identity;
            model.transform.localScale = Vector3.one;
        }

        currentItemModel = model;
    }
}
