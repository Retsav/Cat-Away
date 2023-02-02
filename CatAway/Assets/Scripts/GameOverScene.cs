using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScene : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighscoreText;
    
    private float Score;
    private int RealScore;
    
    void Awake()
    {
        Score=PlayerPrefs.GetFloat("Points");
        RealScore=Mathf.FloorToInt(Score);
        ScoreText.text = "Score:" + RealScore;
        
    }

   

    
   
}
