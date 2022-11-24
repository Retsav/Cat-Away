using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //Skrypt przetrzymuje warto�� punkt�w kt�re ��cznie gracz zebra�.
    [SerializeField] public float Points = 0f;
    //Zmienna odpowiadaj�ca za ilo�� punkt�w dodawanych
    [SerializeField] private float IncreasePerTime = 1f;
    //Powi�zanie z playerem
    [SerializeField] private Player player;
    //Mno�nik szybko�ci zbierania punkt�w (nadaje efekt nabijania punkt�w jak np. w Subway Sufers)
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
