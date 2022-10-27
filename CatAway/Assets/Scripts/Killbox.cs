using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Killbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var PlayerComponent = collision.gameObject.GetComponent<Player>();
        if (PlayerComponent == null)
        {
            return;
        }
        PlayerComponent.Death();
    }
}
