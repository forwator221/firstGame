using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public ScriptableObject item;

    public GameObject itemIcon;
    public Text itemAmount;

    public int amount;

    public bool isEmpty = true;

    private void Start()
    {
        itemIcon = transform.GetChild(0).GetChild(0).gameObject;
        itemAmount = transform.GetChild(0).GetChild(1).GetComponent<Text>();
    }
    public void SetIcon(Sprite _icon)
    {
        itemIcon.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        itemIcon.GetComponent<Image>().sprite = _icon;
    }
}