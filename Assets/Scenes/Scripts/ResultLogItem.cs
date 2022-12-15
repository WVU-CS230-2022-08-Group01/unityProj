using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultLogItem : MonoBehaviour
{
    public void SetResult(string result)
    { 
        GetComponent<Text>().text = result;
        Debug.Log(GetComponent<Text>().text);
    }
}
