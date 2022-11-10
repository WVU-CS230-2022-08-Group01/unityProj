using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerTag : MonoBehaviour
{
    bool answerBotRight;
    bool answerBotLeft;
    bool answerUpLeft;
    bool answerUpRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void instantiateBotRight(bool answerTag)
    {
        answerBotRight = answerTag;
    }

    void instantiateBotLeft(bool answerTag)
    {
        answerBotLeft = answerTag;
    }

   void instantiateUpLeft(bool answerTag)
    {
        answerUpLeft = answerTag;
    }

    void instatiateUpRight(bool answerTag)
    {
        answerUpRight = answerTag;
    }
}
