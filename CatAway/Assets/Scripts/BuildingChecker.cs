using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuildingChecker : MonoBehaviour
{

    public bool inaway = true;
    [SerializeField] private V_SpawnerManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Building")) {
            inaway = false;
        }
        inaway = true;
    }
}
