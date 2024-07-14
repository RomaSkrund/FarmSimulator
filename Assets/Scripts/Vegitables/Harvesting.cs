using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Harvesting : MonoBehaviour
{
    private ContactFarmerWithGrownVegitables _contactFarmerWithGrownVegitables;
    private ChooseVegitable _chooseVegitable;
    private Coins _coins;

    [Inject]
    private void Construct(ContactFarmerWithGrownVegitables contactFarmerWithGrownVegitables,
        ChooseVegitable chooseVegitable,
        Coins coins)
    {
        _contactFarmerWithGrownVegitables = contactFarmerWithGrownVegitables;
        _chooseVegitable = chooseVegitable;
        _coins = coins;
    }

    private void OnEnable()
    {
        _contactFarmerWithGrownVegitables.onVegitablesContacted += GetCoins;
    }

    private void OnDisable()
    {
        _contactFarmerWithGrownVegitables.onVegitablesContacted -= GetCoins;
    }

    private void GetCoins()
    {
        _coins.onCoinsAdded?.Invoke(_chooseVegitable.VegitableCost);
    }
}
