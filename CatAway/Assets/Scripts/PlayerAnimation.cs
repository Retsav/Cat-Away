using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _anim;
   
    void Start()
    {
        _anim = GetComponent <Animator>();
    }

    public void Run (bool running){
        _anim.SetBool("Running", running);
    }

   
    public void Jump( bool jumping)
    {
        _anim.SetBool("Jumping", jumping);
    }
}
