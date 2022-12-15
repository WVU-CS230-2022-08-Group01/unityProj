using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeValue = 90; //set initial value of timer to 90 seconds for 1:30 min
    public Text timerText; //the timer value that is displayed on screen 


    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime; //decrement time 
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue); //display the updated timer value 
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0) //ensures negative time is never displayed 
        {
            timeToDisplay = 0;
            QuizManager n = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
            n.incrementDecrement(false);
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); //calculates minute value 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); //calculates seconds value 
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); //formats display
    }

    public void refresh()
    {
        timeValue = 90; //sets timer value to 1:30 at every refresh 
    }
}
