using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;


public class FileReading : MonoBehaviour
{
    //Create global variables for lists
    List<string> questionList = new List<string>();
    List<string> rightAnswerList = new List<string>();
    List<string[]> wrongAnswerListList = new List<string[]>();

    // Start is called before the first frame update
    void Start()
    {
     
        ReadFile("readTest.txt");
    }

    public void ReadFile(string fileName)
    {
        string filePath = Application.dataPath + "/" + fileName;

        //Variable for name of file to be read

        //Initialize empty lists for question's  wrong answers
        //questionList = new List<string>();
        //rightAnswerList = new List<string>();
        List<string> wrongAnswerList = new List<string>();
        //wrongAnswerListList = new List<string[]>();

        //Read file, iterate through one line at a time
        foreach (string fileLine in System.IO.File.ReadLines(@filePath))
        {
            //Split line at the commas, create array with each element a comma separated string
            string[] lineArr = fileLine.Split(',');

            
            //Add element from array to respective list
            
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

        foreach (var arr in wrongAnswerListList)
        {
            foreach (var str in arr)
            {
                Debug.Log(str);
            }
        }
    }

    public string[] getQuestionArr()
    {
        return this.questionList.ToArray();
    }

    public string[] getRightAnswerArr()
    {
        return this.rightAnswerList.ToArray();
    }

public string[][] getWrongAnswerListArr()
    {
        return this.wrongAnswerListList.ToArray();
    }


}

