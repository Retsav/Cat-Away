using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody2D;

    [SerializeField]
    private float jumpUpPower = 15f;

    [SerializeField]
    private GroundChecker groundChecker;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (groundChecker.IsTouchingGround && Input.GetButtonDown("Jump"))
        {
            _rigidbody2D.velocity += Vector2.up * jumpUpPower;
        }
    }
}
