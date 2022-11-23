using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class V_SpawnerManager : MonoBehaviour
{
    [SerializeField]
    private List<ObjectSpawner> objectSpawners;
    [SerializeField]
    private float SpawnEvery = 2f;


    private void DoRandomSpawner()
    {
        var random = objectSpawners.OrderBy(_ => Guid.NewGuid()).First();
        random.SpawnRandom();
    }
    void Start()
    {
        InvokeRepeating("DoRandomSpawner", 0f, SpawnEvery);

    }
}

