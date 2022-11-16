using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    [SerializeField] private Score Score;
    [SerializeField] private int pointsToAdd = 10;
    private bool isCollected = false;

    private void Start()
    {
        Score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
    void Update()
    {
        if(isCollected)
        {
            Score.Points += pointsToAdd;
            Debug.Log("Zebrano mnie");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
            isCollected = true;
    }
}
