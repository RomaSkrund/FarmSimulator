using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CoinsView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    
    private Coins _coins;

    [Inject]
    private void Construct(Coins coins)
    {
        _coins = coins;
    }

    private void OnEnable()
    {
        _coins.onCoinsValueChanged += ChangeText;
    }

    private void OnDisable()
    {
        _coins.onCoinsValueChanged -= ChangeText;
    }

    private void ChangeText()
    {
        _textMeshPro.text = _coins.CoinsCount.ToString();
    }
}
