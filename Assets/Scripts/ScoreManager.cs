using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    //private int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Debug.Log("The score is " + score.ToString());
        //instance = this;
    }

    public void AddPoint()
    {
        score += 1;
        Debug.Log("The score is " + score.ToString());
    }
}
