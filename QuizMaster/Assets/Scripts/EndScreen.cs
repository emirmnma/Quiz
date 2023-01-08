using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scorekeeper;
    void Start()
    {
        scorekeeper = FindObjectOfType<ScoreKeeper>();
    }

   
   

    public void ShowFinalScore()
    {
        finalScoreText.text = "Tebrikler";
    }
}
