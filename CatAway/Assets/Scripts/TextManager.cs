using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    [SerializeField] private Score score;
    TextMeshPro countertext;

    void Start()
    {
        countertext = GetComponent<TextMeshPro>();
           
    }


    void Update()
    {
        countertext.text = Mathf.Floor(score.Points).ToString();
    }
}
