using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quiz Question",fileName ="New Question")]

public class QuestionSO :ScriptableObject
{
    [SerializeField] string[] Answers = new string[4];
    [Multiline(7)] [SerializeField] string question;
    [SerializeField] int CorrectAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswer(int Index)
    {
        return Answers[Index];
    }

    public int GetCorrectAnswerIndex()
    {
        return CorrectAnswerIndex;
    }

   
}
