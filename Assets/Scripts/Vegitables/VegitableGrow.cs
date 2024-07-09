using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class VegitableGrow : MonoBehaviour
{
    [SerializeField] private GameObject _smallGrassPrefab;
    [SerializeField] private GameObject _bigGrassPrefab;
    [SerializeField] private Transform _parentPrefab;

    private IVegitable? _vegitable;

    private bool _vegitableIsGrown = false;
    public bool vegitableIsGrown => _vegitableIsGrown;

    private void Start()
    {
        StartGrow();
    }

    private void OnEnable()
    {
        ChooseVegitable.onVegitableChoosen += StartGrow;
        ChooseVegitable.onVegitableChoosenInterface += SetTypeVegitable;
    }

    private void OnDisable()
    {
        ChooseVegitable.onVegitableChoosen -= StartGrow;   
        ChooseVegitable.onVegitableChoosenInterface -= SetTypeVegitable;
    }

    private void StartGrow()
    {
        StartCoroutine(Growing());
    }

    public void SetTypeVegitable(IVegitable vegitable)
    {
        _vegitable = vegitable;
    }

    private IEnumerator Growing()
    {
        GameObject prefab  = Instantiate(_smallGrassPrefab, _parentPrefab);
        yield return new WaitForSeconds(_vegitable.GrowSpeed / 2);
        Destroy(prefab);
        prefab = Instantiate(_bigGrassPrefab, _parentPrefab);
        yield return new WaitForSeconds(_vegitable.GrowSpeed / 2);
        Destroy(prefab);
        Instantiate(_vegitable.VegitablePrefab, _parentPrefab);
        _vegitableIsGrown = true;
        yield break;
    }
}
