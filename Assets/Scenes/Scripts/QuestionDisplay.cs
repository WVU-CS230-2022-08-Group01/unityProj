using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionDisplay : MonoBehaviour
{
    void Start()
    {
     	QuizManager n = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
	string question = n.returnQuest();
	display(question);
    }

    void display(string question)
    {
	GameObject.Find("Question").GetComponentInChildren<Text>.text = question;
    }
}
