using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerTag : MonoBehaviour
{
    bool answerBot = false;
    Randomizer sn1;
    Randomizer sn2;
    Randomizer sn3;
    Randomizer sn4;
    QuizManager sc;


    // Start is called before the first frame update
    void Start()
    {
        answerBot = false;
        sc = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
    }

    public void instantiateBotRight()
    {
        sc = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
        sn1 = GameObject.Find("QuizOverseer").GetComponent<Randomizer>();
        answerBot = sn1.correctPosition(3);
        sc.incrementDecrement(answerBot);
    }

    public void instantiateBotLeft()
    {
        sc = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
        sn2 = GameObject.Find("QuizOverseer").GetComponent<Randomizer>();
        answerBot = sn2.correctPosition(2);
        sc.incrementDecrement(answerBot);
    }

   public void instantiateUpLeft()
    {
        sc = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
        sn3 = GameObject.Find("QuizOverseer").GetComponent<Randomizer>();
        answerBot = sn3.correctPosition(0);
        sc.incrementDecrement(answerBot);
    }

    public void instatiateUpRight()
    {
        sc = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
        sn4 = GameObject.Find("QuizOverseer").GetComponent<Randomizer>();
        answerBot = sn4.correctPosition(1);
        sc.incrementDecrement(answerBot);
    }
}
