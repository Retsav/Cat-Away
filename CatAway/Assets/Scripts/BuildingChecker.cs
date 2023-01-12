using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuildingChecker : MonoBehaviour
{
    [SerializeField] private V_SpawnerManager manager;
    private void OnTriggerExit2D(Collider2D collision)
    {
        //To jest obrzydliwie napisane, ale nie mam ju¿ si³y.
        if (collision.gameObject.CompareTag("Platform"))
        {
            return;
        } else if (collision.gameObject.CompareTag("Collectible"))
        {
            return;
        }
        manager.DoRandomSpawner();
    }
}
