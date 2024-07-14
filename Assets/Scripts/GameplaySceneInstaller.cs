using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameplaySceneInstaller : MonoInstaller
{
    [SerializeField] private ContactFarmerWithGrownVegitables _contactFarmerWithGrownVegitables;
    [SerializeField] private ChooseVegitable _chooseVegitable;
    [SerializeField] private Coins _coins;
    [SerializeField] private SpawnGardenBeds _spawnGardenBeds;

    public override void InstallBindings()
    {
        Container.Bind<ContactFarmerWithGrownVegitables>().FromInstance(_contactFarmerWithGrownVegitables);
        Container.Bind<ChooseVegitable>().FromInstance(_chooseVegitable);
        Container.Bind<Coins>().FromInstance(_coins);
        Container.Bind<SpawnGardenBeds>().FromInstance(_spawnGardenBeds);
    }
}
