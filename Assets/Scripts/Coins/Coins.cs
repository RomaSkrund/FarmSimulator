using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private int _coinsCount = 0;

    public int CoinsCount => _coinsCount;

    public Action<int> onCoinsAdded;
    public Action<int> onCoinsRemoved;
    public Action onCoinsValueChanged;

    private void OnEnable()
    {
        onCoinsAdded += AddCoins;
        onCoinsRemoved += RemoveCoins;
    }

    private void OnDisable()
    {
        onCoinsAdded -= AddCoins;
        onCoinsRemoved -= RemoveCoins;
    }

    private void AddCoins(int coinsValue)
    {
        _coinsCount += coinsValue;
        onCoinsValueChanged?.Invoke();
    }

    private void RemoveCoins(int coinsValue)
    {
        _coinsCount -= coinsValue;
        onCoinsValueChanged?.Invoke();
    }
}
