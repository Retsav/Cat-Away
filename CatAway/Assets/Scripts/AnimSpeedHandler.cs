using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSpeedHandler : MonoBehaviour
{
    private Score score;
    private Animator anim;
    [SerializeField]
    private Animator catanim;
    private Player player;
    [SerializeField] 
    private ObjectSpawner spawner;
    //
    void Start()
    {
        anim = GetComponent<Animator>();
        catanim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
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
