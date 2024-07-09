using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour, IVegitable
{
    [SerializeField] private GameObject _tomatoPrefab;
    [SerializeField] private int _cost;
    [SerializeField] private float _growSpeed;

    public int VegitableCost => _cost;
    public float GrowSpeed => _growSpeed;
    public GameObject VegitablePrefab => _tomatoPrefab;
}
