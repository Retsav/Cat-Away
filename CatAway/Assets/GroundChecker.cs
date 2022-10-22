using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(BoxCollider2D))]
public class GroundChecker : MonoBehaviour
{
    private BoxCollider2D _boxCollider;
    
    [SerializeField]
    private GameObject _groundObject;

    public bool IsTouchingGround => _groundObject != null;
    
    private void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (_groundObject != null || !col.gameObject.CompareTag("Obstacle"))
            return;

        _groundObject = col.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject != _groundObject)
            return;

        _groundObject = null;
    }
}
