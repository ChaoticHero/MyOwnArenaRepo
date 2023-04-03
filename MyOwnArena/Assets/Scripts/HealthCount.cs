using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCount : MonoBehaviour
{
    private int Lives = 3;

    [SerializeField] private Text ItemsText;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            --Lives;
            ItemsText.text = "Lives " + Lives;
        }
    }
}

