using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEvents : MonoBehaviour
{
    
    KeyCode nextKey = KeyCode.Space;

    void Update(){
        if(Input.GetKeyDown(nextKey))
        {
            SceneManager.LoadScene(2);
            Debug.Log("Nowa scena");
        }
    }
}
