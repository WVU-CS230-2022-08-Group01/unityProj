using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    void Start()
    {
    QuizManager n = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
	string question = n.returnQuest();
	display(question);
    }

    public void display(string question)
    {
	GameObject.Find("questionDisplay").GetComponentInChildren<Text>().text = question;
    }
}
