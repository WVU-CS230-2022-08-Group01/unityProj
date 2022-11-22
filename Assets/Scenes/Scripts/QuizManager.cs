using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
//public class QuizManager : ScriptableObject
{
    public static QuizManager Instance { get; private set; }
    public int correct = 0;
    public int incorrect = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        correct = 0;
        incorrect = 0;
    }

    public void incrementDecrement(bool result)
    {
        if (result)
            correct++;
        else
            incorrect++;

        //if question pool is not empty
        refresher();
    }

    public void refresher()
    {
        //calls randomize and resets timer
    }


}
