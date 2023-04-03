using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCount : MonoBehaviour
{
    private int Items = 0;

    [SerializeField] private Text ItemsText;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Item")
        {
            ++Items;
            ItemsText.text = "Items Collected " + Items;
        }
    }
}
