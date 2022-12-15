using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;


public class FileReading : MonoBehaviour
{
    //Create global variables for lists
    private List<string> questionList = new List<string>();
    private List<string> rightAnswerList = new List<string>();
    private List<string[]> wrongAnswerListList = new List<string[]>();
    private List<string> results = new List<string>();

    public string fileName;

    // Start is called before the first frame update
    void Start()
    {
        SceneSwitchQuiz Quiz = GameObject.Find("QuizOverseer").GetComponent<SceneSwitchQuiz>();
    }

    public void ReadFile(string fileName)
    {
        string filePath = Application.dataPath + "/" + fileName;
        UnityEngine.Debug.Log(filePath);

        //Initialize empty lists for question's  wrong answers
        List<string> wrongAnswerList = new List<string>();

        //Read file, iterate through one line at a time
        foreach (string fileLine in System.IO.File.ReadLines(@filePath))
        {
            //Split line at the commas, create array with each element a comma separated string
            string[] lineArr = fileLine.Split(',');

            //Add element from split line to respective list
            this.questionList.Add(lineArr[0]);
            this.rightAnswerList.Add(lineArr[1]);
            wrongAnswerList.Add(lineArr[2]);
            wrongAnswerList.Add(lineArr[3]);
            wrongAnswerList.Add(lineArr[4]);
             
            //Convert wrong answers to array
            string[] wrongAnswerArr = wrongAnswerList.ToArray();

            //Add to wrong answers list list
            this.wrongAnswerListList.Add(wrongAnswerArr);

            //Clear WrongAnswerList
            wrongAnswerList.Clear();

        }
    }

    public List<string> ReadResults(string fileName)
    {
        string filePath = fileName;
        UnityEngine.Debug.Log(filePath);

        results = new List<string>();

        foreach (string fileLine in System.IO.File.ReadLines(@filePath))
        {
            string[] lineArr = fileLine.Split(';');
            string lineToStore = lineArr[0] + "     " + lineArr[1] + "     " + lineArr[2] + "%     " + lineArr[3];
            Debug.Log(lineToStore);
            results.Add(lineToStore);
        }

        return results;
    }

    public string[] getQuestionArr()
    {
        SceneSwitchQuiz Quiz = GameObject.Find("QuizOverseer").GetComponent<SceneSwitchQuiz>();
        ReadFile(fileName);
        return this.questionList.ToArray();
    }

    public string[] getRightAnswerArr()
    {
        SceneSwitchQuiz Quiz = GameObject.Find("QuizOverseer").GetComponent<SceneSwitchQuiz>();
        ReadFile(fileName);
        return this.rightAnswerList.ToArray();
    }

    public string[][] getWrongAnswerListArr()
    {
        SceneSwitchQuiz Quiz = GameObject.Find("QuizOverseer").GetComponent<SceneSwitchQuiz>();
        ReadFile(fileName);
        return this.wrongAnswerListList.ToArray();
    }
}

