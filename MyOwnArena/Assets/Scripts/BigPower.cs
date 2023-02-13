using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPower : MonoBehaviour
{

    public float multiplier = 1.6f;
    public GameObject pickupEffect;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pickup(other);
        }
    }

    // Update is called once per frame
    void pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        Debug.Log("Powerup has been picked up");
        player.transform.localScale *= multiplier;

        Destroy(this.transform.parent.gameObject);
    }
}
