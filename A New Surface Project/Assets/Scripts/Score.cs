﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public variable
    public Text scoreDisplay;
    public bool shouldReset = false;
    public Text highscore;
    
    //private variables
    private static int scoreValue = 0;


    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        if (shouldReset == true)
        {
            //reset score back to 0
            scoreValue = 0;
        }
        
        
        //update display of score based on numerical value
        scoreDisplay.text = scoreValue.ToString();
    }

    
    //function to add player's score
    //not automatically called by unity, we need to call it ourselves in our code
    public void AddScore(int toAdd)
    {
        //update the numerical value of the score (action 1)
        scoreValue = scoreValue + toAdd;

        //update display of score based on numerical value
        scoreDisplay.text = scoreValue.ToString();

        if (scoreValue > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", scoreValue);
            highscore.text = scoreValue.ToString();
        }
            
    }
}
