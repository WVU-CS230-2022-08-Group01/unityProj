using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;
using System;

public class FileWriter : MonoBehaviour
{   
    //function for creating a file named fileName if it does not exist
    public void CreateFile(string fileName)
    {
        //Check if file fileName doesn't exist
        if (!File.Exists(fileName))
        {
            //Create file fileName and close file
            File.Create(fileName).Close();
        }
    }

    //function for writing results of quiz taken to file "results.txt"
    //Writes results in format "ChapterX,correct / result,percentVal,date time"
    public void WriteResults(string chapter, string result, double correct, double total)
    {
        //Calculate percent value of correct answers out of total
        double percentVal = (correct / total) * 100;

        //Take the date and time of the system at time of quiz completion
        DateTime time = DateTime.Now;

        //Create string consisting of concatenated strings to make writing to file simpler/cleaner
        string lineToWrite = chapter + "," + result + "," + percentVal.ToString() + "," + time.ToString("F");

        //Create StreamWriter that will append to file "results.txt" if data already exists
        using (StreamWriter writer = new StreamWriter("results.txt", true))
        {
            //Write line to file
            writer.WriteLine(lineToWrite);
        }
    }
}
