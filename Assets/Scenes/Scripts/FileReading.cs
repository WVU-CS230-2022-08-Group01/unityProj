using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;



public class FileReading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start function");
        ReadFile("readTest.txt");
    }
//string[], string[], string[]
    public void ReadFile(string fileName)
    {
        Debug.Log("file reading function");
        string filePath = Application.dataPath + "/" + fileName;
        Debug.Log(fileName);
        Debug.Log(filePath);
       



        /* fileName = "readTest.txt";
         filePath = Application.dataPath + "/" + fileName;
         ReadFile();*/

        //Variable for name of file to be read

        //Initialize empty lists
        List<string> questionList = new List<string>();
        List<string> rightAnswerList = new List<string>();
        List<string> wrongAnswerList = new List<string>();
        //var wrongAnswerListList = new List<string>();

        //Read file, iterate through one line at a time
        foreach (string fileLine in System.IO.File.ReadLines(@filePath))
        {
            //Split line at the commas, create array with each element a comma separated string
            string[] lineArr = fileLine.Split(',');

            Debug.Log(lineArr[0]);
            Debug.Log(lineArr[1]);
            Debug.Log(lineArr[2]);
            Debug.Log(lineArr[3]);
            Debug.Log(lineArr[4]);

            //Add element from array to respective list
            
            questionList.Add(lineArr[0]);
            rightAnswerList.Add(lineArr[1]);
            wrongAnswerList.Add(lineArr[2]);
            wrongAnswerList.Add(lineArr[3]);
            wrongAnswerList.Add(lineArr[4]);
        }
        //Convert lists to respective arrays
       // print(questionList);

        string[] questionArr = questionList.ToArray();
        string[] rightAnswerArr = rightAnswerList.ToArray();
        string[] wrongAnswerArr = wrongAnswerList.ToArray();

       // print(questionArr);

        //Create 2d Array with 

       // return (questionArr, rightAnswerArr, wrongAnswerArr);

    }
}


/*questionList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));
rightAnswerList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));
wrongAnswerList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));
wrongAnswerList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));
wrongAnswerList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));*/


/* questionArr[n]=fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
 rightAnswerArr[n]=fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
wrongAnswerArr[b]=fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
 wrongAnswerArr[b+1] = fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
 wrongAnswerArr[b+2] = fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);*/