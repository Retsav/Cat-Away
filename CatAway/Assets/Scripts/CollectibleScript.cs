using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    [SerializeField] private Score Score;
    [SerializeField] private float pointsToAdd = 10f;
    private bool isCollected = false;

    private void Start()
    {
        //Skrypt przy rozpoczêciu swojego ¿ycia natychmiastowo szuka w grze GameObjectu z tagiem "Score" i pobiera z niego potrzebn¹ nam klase.
        Score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
    void Update()
    {
        //Je¿eli isCollected jest w³¹czone, dodaj pointsToAdd do skryptu Points w skrypcie "Score", a nastêpnie zniszcz GameObject.
        if(isCollected)
        {
            Score.Points += pointsToAdd;
            Debug.Log("Zebrano mnie");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //OnTriggerEnter2D sprawdza czy obiekt jest Playerem, je¿eli nie to return, w przeciwnym razie prze³¹cz isCollected na true.  
        if(!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
            isCollected = true;
    }
}
