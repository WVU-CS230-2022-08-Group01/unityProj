using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
//public class QuizManager : ScriptableObject
{
    public static QuizManager Instance { get; private set; }
    public int correct;
    public int incorrect;
    public int index;
    public string[][] wrongAnswerList;
    public string[] rightAnswerList;
    public string[] questionList;


    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        correct = 0;
        incorrect = 0;
        FileReading fr = GameObject.Find("QuizOverseer").GetComponent<FileReading>();
        QuestionDisplay q = GameObject.Find("questionDisplay").GetComponent<QuestionDisplay>();
        questionsAndAnswers(fr);
        q.display(returnQuest());
    }

    void Update()
    {
        //Initialize object for storing active scene data, store name of scene in string variable
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        //Check if sceneName contains word "Chapter", if so change chapter string in QuizName component to sceneName.
        if (sceneName.Contains("Chapter"))
        {
            QuizName.chapter = sceneName;
        }
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("correct", correct);
        PlayerPrefs.SetInt("incorrect", incorrect);
    }

    void OnEnable()
    {
        correct = PlayerPrefs.GetInt("correct");
        incorrect = PlayerPrefs.GetInt("incorrect");
    }

    public void questionsAndAnswers(FileReading fr)
    {
        questionList = fr.getQuestionArr();
        rightAnswerList = fr.getRightAnswerArr();
        wrongAnswerList = fr.getWrongAnswerListArr();
    }

    public string returnQuest()
    {
        string quest = questionList[index];
        return quest;
    }

    public string returnWrong1()
    {
        string wrong1 = wrongAnswerList[index][0];
        return wrong1;
    }

    public string returnWrong2()
    {
        string wrong2 = wrongAnswerList[index][1];
        return wrong2;
    }

    public string returnWrong3()
    {
        string wrong3 = wrongAnswerList[index][2];
        return wrong3;
    }

    public string returnAns()
    {
        string right = rightAnswerList[index];
        return right;
    }

    public void incrementDecrement(bool result)
    {
        if (result)
        {
            correct++;
        }
        else
        {
            incorrect++;
        }

        //if question pool is not empty
        if (index < questionList.Length-1)
        {
            refresher();
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    public int getCorrect()
    {
        return correct;
    }

    public int getIncorrect()
    {
        return incorrect;
    }

    public void refresher()
    {
        //resets randomize and resets timer
        index++;
        Randomizer res = GameObject.Find("QuizOverseer").GetComponent<Randomizer>();
        res.refresh();
        Timer res2 = GameObject.Find("Timer").GetComponent<Timer>();
        res2.refresh();
        QuestionDisplay q = GameObject.Find("questionDisplay").GetComponent<QuestionDisplay>();
        q.display(returnQuest());
    }


}
