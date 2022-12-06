using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    string pointKey = "Point";

    public int CurrentScore {get; set;}

    private void Awake(){
        CurrentScore = PlayerPrefs.GetInt(pointKey);
    }

    public void SetPoint(int point)
    {
        PlayerPrefs.SetInt(pointKey, point);
    }
}
