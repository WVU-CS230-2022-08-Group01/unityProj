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
        string[] wrong = { "wrong", "wrong", "wrong" };
        randomize("correct button",wrong);
    }

    //error related 
    void randomize(string correct, string[] incorrect)
    {
        //upLeft is 1
        //upRight is 2
        //botLeft is 3
        //botRight is 4

        //list of possible positions
        List<int> btns = new List<int> { 1, 2, 3, 4};
        //assign position of correct answer
        int position = UnityEngine.Random.Range(0,btns.Count);
        //assign correct answer to random position and update btns
        //correct answer can be assigned multiple times
        btns = assignBtn(btns, correct, position);
        //intstatiates correctPos to hold the correct answer position
        correctPos = position;

        //for each incorrect answer
        for(int i = 0; i < 3; i++)
        {
            //check if only one element left in btns
            if (btns.Count == 1)
            {
                //if statement never runs
                //assign curret element to last element in btns
                btns = assignBtn(btns, incorrect[i], position);
            }
            else
            {
                //generate new position
                position = UnityEngine.Random.Range(0, btns.Count);
               
                //assign current element to position and update btns
                btns = assignBtn(btns, incorrect[i], position);
                
            }
            //bug related to random.range, check if position hasn't been used before with btns
            
        }
    }

    List<int> assignBtn(List<int> btns, string answer, int position)
    {
        //check what the given position is
        switch (position)
        {
            case 1:
                //edit text of upLeft to be answer
                GameObject.Find("upLeft").GetComponentInChildren<Text>().text = answer;
                //remove 1 from buttons array
                btns.RemoveAt(0);
                break;
            case 2:
                //edit text of upRight to be answer
                GameObject.Find("upRight").GetComponentInChildren<Text>().text = answer;
                //remove 2 from buttons array
                btns.RemoveAt(1);
                break;
            case 3:
                //edit text of botLeft to be answer
                GameObject.Find("botLeft").GetComponentInChildren<Text>().text = answer;
                //remove 3 from buttons array
                btns.RemoveAt(2);
                break;
            case 4:
                //edit text of botRight to be answer
                GameObject.Find("botRight").GetComponentInChildren<Text>().text = answer;
                //remove 4 from buttons array
                btns.RemoveAt(3);
                break;
        }
        return btns;
    }

    //method to return if the button pressed is the correct button
    //takes the pressed buttons position as input then checks if it is the correct button, if true then returns true, lese returns false
    public bool correctPosition(int buttonPos)
    {
        if(buttonPos == correctPos)
            return true;

        return false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
