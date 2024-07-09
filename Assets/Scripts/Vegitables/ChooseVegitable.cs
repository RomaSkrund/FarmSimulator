using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChooseVegitable : MonoBehaviour
{
    [SerializeField] private Tomato _tomato;
    [SerializeField] private Cabbage _cabbage;

    public static event Action onVegitableChoosen;
    public static event Action<IVegitable> onVegitableChoosenInterface;

    private void OnEnable()
    {
        SpawnGardenBeds.onGardenSpawned += Initialize;
    }

    private void OnDisable()
    {
        SpawnGardenBeds.onGardenSpawned -= Initialize;
    }

    public void Initialize()
    {
        onVegitableChoosenInterface?.Invoke(_tomato);
        onVegitableChoosen?.Invoke();
    }
}
