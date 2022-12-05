using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




//big note
//please get input from file reading for the buttons
//big note




public class Randomizer : MonoBehaviour
{
    //int variable to hold the correct position for the correct answer
    int correctPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        QuizManager n = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
        string[] wrong = { n.returnWrong1(), n.returnWrong2(), n.returnWrong3() };
        randomize(n.returnAns(), wrong);
    }

    //error related 
    void randomize(string correct, string[] incorrect)
    {
        //upLeft is 0
        //upRight is 1
        //botLeft is 2
        //botRight is 3

        //list of possible positions
        List<int> btns = new List<int> { 0, 1, 2, 3};
        //assign position of correct answer
        correctPos = UnityEngine.Random.Range(0,btns.Count);
        //assign correct answer to random position and update btns
        //correct answer can be assigned multiple times
        btns = assignBtn(btns, correct, correctPos);

        //for each incorrect answer
        for(int i = 0; i < 3; i++)
        {
            int position = UnityEngine.Random.Range(0, btns.Count-1);
            //generate new position
            position = btns.ToArray()[position];
            //assign current element to position and update btns
            btns = assignBtn(btns, incorrect[i], position);
        }
    }

    List<int> assignBtn(List<int> btns, string answer, int position)
    {
        //check what the given position is

        switch (position)
        {
            case 0:
                //edit text of upLeft to be answer
                GameObject.Find("upLeft").GetComponentInChildren<Text>().text = answer;
                //remove 1 from buttons array
                btns.Remove(0);
                break;
            case 1:
                //edit text of upRight to be answer
                GameObject.Find("upRight").GetComponentInChildren<Text>().text = answer;
                //remove 2 from buttons array
                btns.Remove(1);
                break;
            case 2:
                //edit text of botLeft to be answer
                GameObject.Find("botLeft").GetComponentInChildren<Text>().text = answer;
                //remove 3 from buttons array
                btns.Remove(2);
                break;
            case 3:
                //edit text of botRight to be answer
                GameObject.Find("botRight").GetComponentInChildren<Text>().text = answer;
                //remove 4 from buttons array
                btns.Remove(3);
                break;
        }
        return btns;
    }

    //method to return if the button pressed is the correct button
    //takes the pressed buttons position as input then checks if it is the correct button, if true then returns true, lese returns false
    public bool correctPosition(int buttonPos)
    {
        if (buttonPos == correctPos)
            return true;

        return false;
    }

    // refreshes the question bank
    public void refresh()
    {
        QuizManager n = GameObject.Find("QuizOverseer").GetComponent<QuizManager>();
        string[] wrong = { n.returnWrong1(), n.returnWrong2(), n.returnWrong3() };
        randomize(n.returnAns(), wrong);
    }
}
