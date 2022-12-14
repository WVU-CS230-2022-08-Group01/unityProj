using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;
using System;

public class FileWriter : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            File.Create(fileName).Close();
        }
    }

    public void WriteResults(string chapter, string result, double correct, double total)
    {
        string[] results = Regex.Split(result, @"\D+");

        double percentVal = (correct / total) * 100;
        Debug.Log(percentVal);
        DateTime time = DateTime.Now;

        string lineToWrite = chapter + "," + result + "," + percentVal.ToString() + "," + time.ToString("F");

        using (StreamWriter writer = new StreamWriter("results.txt", true))
        {
            writer.WriteLine(lineToWrite);
        }
    }
}
