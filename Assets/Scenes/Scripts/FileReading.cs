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
        //ReadFile("readTest.txt", Application.dataPath + "/" + "readTest.txt");
    }


    public void ReadFile(string fileName)
    {
        string filePath = Application.dataPath + "/" + fileName;
        ReadFile("readTest.txt", filePath);

        /* fileName = "readTest.txt";
         filePath = Application.dataPath + "/" + fileName;
         ReadFile();*/

        //Variable for name of file to be read


        //Initialize empty lists
        var questionList = new List<string>();
        var rightAnswerList = new List<string>();
        var wrongAnswerList = new List<string>();
        //var wrongAnswerListList = new List<string>();


        int n = 0;
        int b = 0;

    //Read all lines of text file
        string[] fileLines = File.ReadAllLines(filePath);


        foreach(string fileLine in fileLines)
        {
            questionList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));
            rightAnswerList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));
            wrongAnswerList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));
            wrongAnswerList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));
            wrongAnswerList.Add(fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries));


            /* questionArr[n]=fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
             rightAnswerArr[n]=fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
            wrongAnswerArr[b]=fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
             wrongAnswerArr[b+1] = fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
             wrongAnswerArr[b+2] = fileLine.Split(',', StringSplitOptions.RemoveEmptyEntries);*/

            string[] questionArr=questionList.ToArray();
            string[] rightAnswerArr=rightAnswerList.ToArray();
           

            print(questionArr[n]);
            print(rightAnswerArr[n]);

                n++;
            b = b + 3;

        }
      /* using (StreamReader reader = new StreamReader(filename))
        {
            while(!reader.EndOfStream) //while reading the file, we haven't reached the end
            {
                //keep reading
                Debug.Log(reader.ReadLine());  //read line, print to console

            }
        }*/
    }

   /* private void WriteFile()
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            
            writer.WriteLine(i.ToString());
        }
    }*/
}
