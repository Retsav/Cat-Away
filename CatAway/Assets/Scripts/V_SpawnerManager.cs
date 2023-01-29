using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class V_SpawnerManager : MonoBehaviour
{
    [SerializeField]
    private List<ObjectSpawner> objectSpawners;
    [SerializeField] private BuildingChecker buildingChecker;

    public void DoRandomSpawner()
    {
        Invoke("CreateObstacle",0.05f);
        return;
    }

    public void CreateObstacle()
    {
        var random = objectSpawners.OrderBy(_ => Guid.NewGuid()).First();
        random.SpawnRandom();
    }
}

