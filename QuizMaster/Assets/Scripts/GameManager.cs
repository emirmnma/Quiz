using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     Quizz quizz;
     EndScreen endscreenn;

    GameObject entering;
    private void Awake()
    {
        quizz = FindObjectOfType<Quizz>();
        endscreenn = FindObjectOfType<EndScreen>();
        entering = GameObject.FindGameObjectWithTag("Enter");
        
    }
    void Start() 
    {
        entering.gameObject.SetActive(true);
        quizz.gameObject.SetActive(false);
        endscreenn.gameObject.SetActive(false);
    }

    
    void Update()
    {
        if (quizz.isComplete == true)
        {
            endscreenn.gameObject.SetActive(true);
            quizz.gameObject.SetActive(false);
            endscreenn.ShowFinalScore();
        }
       
    }


    public void PlayAgainButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quitButton()
    {
        Application.Quit();
    }
    public void StartButton()
    {
        entering.gameObject.SetActive(false);
        quizz.gameObject.SetActive(true);
        endscreenn.gameObject.SetActive(false);
    }
}
