using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // Zmienne do dodanych komponentów
    public BoxCollider2D collider;
    public Rigidbody2D rb;
    private ObjectSpawner spawner;

    // Do przechowywania szerokości backgroundu
    private float width;
    // Do usatalania prędkości
    private float scrollSpeed = -2f;

    void Start()
    { 
        //daje zmienne określonego typu, jeśli są przyłączone do GameObjectu
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<ObjectSpawner>();
        
        //chcemy otrzymać szerokość background'u używając box collider'a
        width = collider.size.x;
        
        //nie potrzeba już collidera aktywego, bo będzię kalkulował kolizje
        collider.enabled =false;

        //ustalenie prędkości
        rb.velocity = new Vector2((scrollSpeed*spawner.DesiredSpeedOverride*5), 0);

    }

    // Kiedy juz tło się przesunie to resetujemy do poprzedniej
    void Update()
    {
        if (transform.position.x < -width)
    {
        Vector2 resetPosition = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position +resetPosition;
    }

    }
}
