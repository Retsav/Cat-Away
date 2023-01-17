using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

/// Komponent odpowiedzialny za logikę gracza.
public class Player : MonoBehaviour
{
    /// Musimy mieć referencję do rigid body obecnego GameObjecta by nim poruszać.
    /// Poruszamy rigidbodym a nie transformem by nasze ruchy były zgodne z silnikiem fizyki.
    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    public bool isDead;
    private PlayerAnimation _playerAnim;
    

    /// Jak wysoko nasz gracz może skoczyć
    [SerializeField]
    private float jumpUpPower = 15f;
    [SerializeField]
    private float GravityPower = 0.1f;
    


    /// Referencja do sub-komponenta gracza.
    /// Sub-komponent znaduje się w osobnym GameObjectie który ma gracza jako parent.
    ///
    /// Ground Checker ma za zadanie określenia czy gracz obecnie dotyka ziemi, czy nie.
    [SerializeField]
    private GroundChecker groundChecker;
    
   
    
    private void Awake()
    {
        // Złapmy referencję do RigidBody podczas spawnu.
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerAnim =GetComponent<PlayerAnimation>();
    }

    private void Update()
    {
        // Jeśli dotykamy ziemi, i właśnie kliknęliśmy spację - skoczmy!
        if (groundChecker.IsTouchingGround && Input.GetButtonDown("Jump"))
        {
            _playerAnim.Jump(true);
            _rigidbody2D.velocity += Vector2.up * jumpUpPower;
        } 
        if (!groundChecker.IsTouchingGround)
        {
           _rigidbody2D.AddForce(Vector2.down * GravityPower);
           _playerAnim.Jump(false);
           _playerAnim.Run(true);
        }
        
        
    }

    public void Death()
    {  
        SceneManager.LoadScene(3);
        isDead = true;
    }
}
