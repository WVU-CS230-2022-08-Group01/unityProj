using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class ScoringManage : MonoBehaviour
{
    public Text pointsText; 
    public static ScoringManage instance;
    public string chapter;
    public string result;
    public int correct;
    public int total;
   
   // At the start of every quiz it will have a score of 0, with the QuizManger Script connected to it. 
   //Both QuizManger and FileWriter will bounces back and forth to read eveny click on the quiz to help manage the score. 
    void Start(){
        int Score = 0;
        QuizManager point = GameObject.Find("Real Score").GetComponent<QuizManager>();
        Score board = GameObject.Find("Real Score").GetComponent<Score>();
        FileWriter fileWriter = GameObject.Find("Real Score").GetComponent<FileWriter>();
        GetPoints(point);

        //Store string for chapter name in global string variable chapter, write results of quiz to "results.txt" file
        chapter = QuizName.chapter;
        fileWriter.WriteResults(chapter, result, correct, total);
    }

    public void AddPoints(){
        Score.totalScore += 1;
    }

    // When the user selects the correct answer, the answer will then get one point.
    //However it will count incorrect answers for total. Finally when finished it will display the total of quesions and corret slections. 
    public void GetPoints(QuizManager point){
        correct = point.getCorrect();
        total = point.getIncorrect() + point.getCorrect();
        result = correct.ToString() + " / " + total.ToString();
        pointsText.text = result;
    }
   
}


   

    
   

