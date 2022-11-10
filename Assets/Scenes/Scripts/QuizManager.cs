using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
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

    void increment()
    {
        correct++;
    }

    void decrement()
    {
        incorrect++;
    }

    int getCorrect()
    {
        return correct;
    }

    int getIncorrect()
    {
        return incorrect;
    }
}
