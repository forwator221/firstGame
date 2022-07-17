using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;
    }
    #endregion

    public int space = 20;

    public List<ItemScriptableObject> items = new List<ItemScriptableObject>();

    public void Add(ItemScriptableObject item)
    {
        if (items.Count >= space)
        {
            Debug.Log("Not enough room");
            return;
        }
        items.Add(item);
    }

    public void Remove(ItemScriptableObject item)
    {
        items.Remove(item);
    }
}
