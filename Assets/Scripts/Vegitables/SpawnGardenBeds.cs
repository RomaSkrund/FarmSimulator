using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGardenBeds : MonoBehaviour
{
    [SerializeField] private GameObject _gardenBegPrefab;
    [SerializeField] private Transform _spawnPoint;

    private Vector3 _actualPosition;

    public Action onGardenSpawned;

    public void Spawn()
    {
        _actualPosition = _spawnPoint.position;

        for(int i = 0; i < 10 ; i++)
        {
            GameObject gardenBed = Instantiate(_gardenBegPrefab, _spawnPoint);
            gardenBed.transform.position = _actualPosition;
            _actualPosition += new Vector3(0, 0, -4);
        }

        onGardenSpawned?.Invoke();
    }
}
