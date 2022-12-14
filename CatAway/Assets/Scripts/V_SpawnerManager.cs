using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class V_SpawnerManager : MonoBehaviour
{
    [SerializeField]
    private List<ObjectSpawner> objectSpawners;
    //[SerializeField]
    //private float SpawnEvery = 2f;
    [SerializeField] private BuildingChecker buildingchecker;

    private void Update()
    {
    }

    public void DoRandomSpawner()
    {
        //if (spawnable) {
            Debug.Log("SPAWNUJE SIE ZYJE");
            var random = objectSpawners.OrderBy(_ => Guid.NewGuid()).First();
            random.SpawnRandom();
            spawnable = false;
        //}
        return; 
    }
    void Start()
    {
        //InvokeRepeating("DoRandomSpawner", 0f,SpawnEvery);

    }
}

