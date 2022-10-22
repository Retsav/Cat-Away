using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> prefabsToSpawn = new();

    [SerializeField]
    private float DesiredSpeedOverride = 1f;

    private void Update()
    {
        SpawnRandom();
    }

    private void SpawnRandom()
    {
        var randomPrefab = prefabsToSpawn.OrderBy(_ => Guid.NewGuid()).First();
        
        var instance = Instantiate(randomPrefab, transform.position, Quaternion.identity);

        if (instance.TryGetComponent<Animator>(out var animator))
        {
            animator.SetFloat("AnimSpeed", DesiredSpeedOverride);
        }
    }
}
