using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    void Start()
    {
        //Initialize component QuizManager for use
        QuizManager n = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();

        //Create string question to store the current question. Display question text for user.
	    string question = n.returnQuest();
	    display(question);
    }

    //function for displaying question text to questionDisplay component text in Quiz scenes.
    //Finds questionDisplay component, gets the Text component within it, and then changes the text displayed to question text
    public void display(string question)
    {
	    GameObject.Find("questionDisplay").GetComponentInChildren<Text>().text = question;
    }
}
