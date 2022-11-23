using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSpeedHandler : MonoBehaviour
{
    private Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
