using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //Skrypt przetrzymuje wartoœæ punktów które ³¹cznie gracz zebra³.
    [SerializeField] public float Points = 0f;
    //Zmienna odpowiadaj¹ca za iloœæ punktów dodawanych
    [SerializeField] private float IncreasePerTime = 1f;
    //Powi¹zanie z playerem
    [SerializeField] private Player player;
    //Mno¿nik szybkoœci zbierania punktów (nadaje efekt nabijania punktów jak np. w Subway Sufers)
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
