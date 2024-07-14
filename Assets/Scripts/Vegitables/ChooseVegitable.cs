using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

public class ChooseVegitable : MonoBehaviour
{
    [SerializeField] private Tomato _tomato;
    [SerializeField] private Cabbage _cabbage;

    private int _vegitableCost = 0;
    public int VegitableCost => _vegitableCost;

    public static Action<IVegitable> onVegitableChoosenInterface;

    private SpawnGardenBeds _spawnGardenBeds;

    [Inject]
    private void Construct(SpawnGardenBeds spawnGardenBeds)
    {
        _spawnGardenBeds = spawnGardenBeds;
    }

    private void Start()
    {
        ChooseStartType();
    }

    private void OnEnable()
    {
        _spawnGardenBeds.onGardenSpawned += ChooseStartType;
    }

    private void OnDisable()
    {
        _spawnGardenBeds.onGardenSpawned -= ChooseStartType;
    }

    public void ChooseStartType()
    {
        ChooseType(_tomato);
    }

    public void CabbageButton()
    {
        ChooseType(_cabbage);
    }

    public void ChooseType(IVegitable vegitable)
    {
        onVegitableChoosenInterface?.Invoke(vegitable);
        _vegitableCost = vegitable.VegitableCost;

    }
}
