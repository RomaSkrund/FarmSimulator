using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

class VegitableGrow : MonoBehaviour
{
    [SerializeField] private GameObject _smallGrassPrefab;
    [SerializeField] private GameObject _bigGrassPrefab;
    [SerializeField] private Transform _parentPrefab;

    private IVegitable? _vegitable;

    private ContactFarmerWithGrownVegitables _contactFarmerWithGrownVegitables;

    [Inject]
    private void Construct(ContactFarmerWithGrownVegitables contactFarmerWithGrownVegitables)
    {
        _contactFarmerWithGrownVegitables = contactFarmerWithGrownVegitables;
    }

    private void OnEnable()
    {
        ChooseVegitable.onVegitableChoosenInterface += SetTypeVegitable;
    }

    private void OnDisable()
    {
        ChooseVegitable.onVegitableChoosenInterface -= SetTypeVegitable;
    }
    public void SetTypeVegitable(IVegitable vegitable)
    {
        _vegitable = vegitable;
        StartGrow();
    }

    public void StartGrow()
    {
        StartCoroutine(Growing());
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
        yield break;
    }
}
