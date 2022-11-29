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
        {
            correct++;
            //Debug.Log("Number correct"+correct);
        }
        else
        {
            incorrect++;
            //Debug.Log("Number incorrect"+incorrect);
        }
        
        //if question pool is not empty
        refresher();
    }

    public int getCorrect()
    {
        return correct;
    }

    public int getIncorrect()
    {
        return incorrect;
    }

    public void refresher()
    {
        //resets randomize and resets timer
        Randomizer res = GameObject.Find("QuizOverseer").GetComponent<Randomizer>();
        res.refresh();
        Timer res2 = GameObject.Find("Timer").GetComponent<Timer>();
        res2.refresh();
    }


}
