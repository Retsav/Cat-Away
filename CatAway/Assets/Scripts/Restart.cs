using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{


    [SerializeField] private Player Player;
    [SerializeField] private TextMeshPro Text;
    void Start()
    {
        Text.enabled = false;
    }

    void Update()
    {
        if(!Player.isDead)
        {
            return;
        }
        Text.enabled = true;
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Scene1");
        }
    }
}
