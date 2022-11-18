using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Komponent odpowiedzialny za logikę gracza.
/// </summary>
public class Player : MonoBehaviour
{
    /// <summary>
    /// Musimy mieć referencję do rigid body obecnego GameObjecta by nim poruszać.
    /// Poruszamy rigidbodym a nie transformem by nasze ruchy były zgodne z silnikiem fizyki.
    /// </summary>
    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    public bool isDead;

    /// <summary>
    /// Jak wysoko nasz gracz może skoczyć
    /// </summary>
    [SerializeField]
    private float jumpUpPower = 15f;
    [SerializeField]
    private float GravityPower = 0.1f;

    /// <summary>
    /// Referencja do sub-komponenta gracza.
    /// Sub-komponent znaduje się w osobnym GameObjectie który ma gracza jako parent.
    ///
    /// Ground Checker ma za zadanie określenia czy gracz obecnie dotyka ziemi, czy nie.
    /// </summary>
    [SerializeField]
    private GroundChecker groundChecker;
    private void Start()
    {
        // Złapmy referencję do RigidBody podczas spawnu.
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Jeśli dotykamy ziemi, i właśnie kliknęliśmy spację - skoczmy!
        if (groundChecker.IsTouchingGround && Input.GetButtonDown("Jump"))
        {
            _rigidbody2D.velocity += Vector2.up * jumpUpPower;
        } 
        if (!groundChecker.IsTouchingGround)
        {
            _rigidbody2D.AddForce(Vector2.down * GravityPower);
        }
    }
    public void Death()
    {
        Destroy(gameObject);
        isDead = true;
    }
}
