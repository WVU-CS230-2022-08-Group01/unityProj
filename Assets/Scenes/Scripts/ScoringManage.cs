using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringManage : MonoBehaviour
{
    public Text pointsText; 
    public static ScoringManage instance;
    Score board = GameObject.Find("Score").GetComponent<Score>();
   
    void Start(){
        int Score = 0;
        //QuizManager point;
        GetPoints(point);
    }

    public void AddPoints(){
        Score.totalScore += 1;
        //scoreText.text = point.getCorrect() + "Points";
    }
    
    public void GetPoints(GameObject point){
        point = GameObject.Find("Score").GetComponent<QuizManager>();
        pointsText.text = point.getCorrect().ToString();
    }
   
}


   

    
   

