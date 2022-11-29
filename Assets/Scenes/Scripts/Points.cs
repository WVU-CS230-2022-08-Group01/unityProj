using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Points : MonoBehaviour{
    public Texts pointsText;
    //I have to change "Scoring" to the class where random buttion is in
    public void AddPoints (){
        Scoring.totalScore += 1;
    }
    public void GetPoints(){
        int recievedPoints= ;
        pointsText.text = recievedPoints.ToString();
    }
}
