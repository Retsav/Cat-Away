using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSpeedHandler : MonoBehaviour
{
    private Animator anim;  
    private Player player;
    [SerializeField] 
    private ObjectSpawner spawner;
  
    void Awake()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<ObjectSpawner>();
    }

    void Update()
    {
        if(player.isDead)
        {
            return;
        }
        anim.SetFloat("AnimSpeed", spawner.desiredSpeedOverride);
    }
}
