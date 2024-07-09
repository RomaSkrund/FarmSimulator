using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private ChooseVegitable _chooseVegitable;

    private void Start()
    {
        _chooseVegitable.Initialize();
    }
}
