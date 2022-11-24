using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSpeedHandler : MonoBehaviour
{
    private Score score;
    private Animator anim;
    [SerializeField]
    private Animator catanim;
    [SerializeField] 
    private ObjectSpawner spawner;
    void Start()
    {
        anim = GetComponent<Animator>();
        catanim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<ObjectSpawner>();
    }

    void Update()
    {
        anim.SetFloat("AnimSpeed", spawner.DesiredSpeedOverride);
        catanim.SetFloat("AnimSpeed", spawner.DesiredSpeedOverride);
    }
}
