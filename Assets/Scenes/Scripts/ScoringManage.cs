using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringManage : MonoBehaviour
{
    
   public static ScoringManage instance;
    Score track = GameObject.Find("Score").GetComponent<Score>();
   //Knowing the score
   public Text pointsText;
   
   // Start off with 0 points 
   int Score = 0;

    //Starting to earn points 
    void Start(){
        QuizManager point;
        GetPoints(point);
        
        //scoreText.text = point.getCorrect() + "Points";
    }

    public Text pointText;
    

    public void GetPoints(GameObject point){
        point = GameObject.Find("Score").GetComponent<QuizManager>();
        pointsText.text = point.getCorrect().ToString();
    }
   
}


   

    
   

