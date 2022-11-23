using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //Skrypt przetrzymuje wartoœæ punktów które ³¹cznie gracz zebra³.
    [SerializeField] public float Points = 0f;
    [SerializeField] private float IncreasePerTime = 1f;
    [SerializeField] private Player player;
    [SerializeField] private float SpeedFactor = 2f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if(!player.isDead == false)
        {
            return;
        }
       Points += IncreasePerTime * Time.deltaTime * SpeedFactor;
    }
}
