using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    
    public bool loadNextQuestion;
    public bool isAnsweringQuestion = false;

    public float fillFraction;
    public float timervalue;
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timervalue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timervalue > 0)
            {
                fillFraction = timervalue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timervalue = timeToShowCorrectAnswer;
            }
            
        }
        else
        {
            if (timervalue > 0)
            {
                fillFraction = timervalue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timervalue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }

    public void CancelTimer()
    {
        timervalue = 0;
    }
        
}
