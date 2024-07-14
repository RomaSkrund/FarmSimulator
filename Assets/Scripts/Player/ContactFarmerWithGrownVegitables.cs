using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactFarmerWithGrownVegitables : MonoBehaviour
{
    public Action onVegitablesContacted;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vegitable"))
        {
            onVegitablesContacted?.Invoke();
            Destroy(other.gameObject);
        }
    }
}
