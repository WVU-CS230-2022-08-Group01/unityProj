using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerTag : MonoBehaviour
{
    bool answerBot = false;
    Randomizer sn = gameObject.GetComponent<Randomizer>();
    QuizManager sc = gameObject.GetComponent<QuizManager>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void instantiateBotRight()
    {

        answerBot = sn.correctPosition(4);
        sc.incrementDecrement(answerBot);
    }

    public void instantiateBotLeft()
    {
        answerBot = sn.correctPosition(3);
        sc.incrementDecrement(answerBot);
    }

   public void instantiateUpLeft()
    {
        answerBot = sn.correctPosition(1);
        sc.incrementDecrement(answerBot);
    }

    public void instatiateUpRight()
    {
        answerBot = sn.correctPosition(2);
        sc.incrementDecrement(answerBot);
    }
}
