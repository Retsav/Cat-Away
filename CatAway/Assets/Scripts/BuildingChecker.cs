using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuildingChecker : MonoBehaviour
{
    [SerializeField] private V_SpawnerManager manager;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            return;
        }
        manager.DoRandomSpawner();
    }
}
