using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuildingChecker : MonoBehaviour
{
    [SerializeField] private V_SpawnerManager manager;
    private void OnTriggerExit2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        switch(tag)
        {
            case "Platform":
                return;
            case "Collectible":
                return;
            case "Obstacle":
                return;
            default:
                manager.DoRandomSpawner();
                break;
        }
    }
}
