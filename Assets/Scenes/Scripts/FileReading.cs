using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileReading : MonoBehaviour
{
    //Variable for name of file to be read
    public string filePath, fileName;

    string[] questionsArr;
    

    // Start is called before the first frame update
    void Start()
    {
        fileName = "readTest.txt";
        filePath = Application.dataPath + "/" + fileName;
        ReadFile();
    }


    public void ReadFile()
    {

        questionsArr = File.ReadAllLines(filePath);

        foreach(string question in questionsArr)
        {
            print(question);
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
