using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// ObjectSpawner jest odpowiedzialny za tworzenie przeszkód na torze gracza.
/// </summary>
public class ObjectSpawner : MonoBehaviour
{
    /// <summary>
    /// Ta lista będzie posiadała wszystkie możliwe Prefaby które mogą być zespawnowane na tym torze
    /// </summary>
    [SerializeField]
    private List<GameObject> prefabsToSpawn = new();

    /// <summary>
    /// Ta zmienna powie naszym Prefabom jak szybko mają się poruszać na torze.
    /// </summary>
    [SerializeField]
    public float DesiredSpeedOverride = 1f;

    /// <summary>
    /// Ta funkcja wybierze losowy obiekt z listy prefabów, oraz go zespawnuje i nada mu prędkość używając Animatora
    /// </summary>
    [SerializeField]
    private Score Score;
    private bool toAdd = false;

    private void Start()
    {
        Score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    public void Add()
    {

        if (Score.Points >= 10 && Score.Points <= 12)
        {
            Debug.Log("Dzialam");
            DesiredSpeedOverride += 0.5f * Time.deltaTime;
        }
    }
    public void SpawnRandom()
    {
        var randomPrefab = prefabsToSpawn.OrderBy(_ => Guid.NewGuid()).First();

        var instance = Instantiate(randomPrefab, transform.position, Quaternion.identity);

        if (instance.TryGetComponent<Animator>(out var animator))
        {
            animator.SetFloat("AnimSpeed", DesiredSpeedOverride);
        }
    }
    private void Update()
    {
       // Add();
    }
}
