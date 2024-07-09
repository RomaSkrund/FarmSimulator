using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Cabbage : MonoBehaviour, IVegitable 
{
    [SerializeField] private GameObject _cabbagePrefab;
    [SerializeField] private int _cost;
    [SerializeField] private float _growSpeed;

    public int VegitableCost => _cost;
    public float GrowSpeed => _growSpeed;
    public GameObject VegitablePrefab => _cabbagePrefab;
}
