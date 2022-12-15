using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultLogItem : MonoBehaviour
{
    //Set text of result to be logged
    public void SetResult(string result)
    { 
        GetComponent<Text>().text = result;
    }
}
