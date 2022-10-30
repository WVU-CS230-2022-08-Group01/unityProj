using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Randomizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void randomize(string correct, string[] incorrect)
    {
        //upLeft is 1
        //upRight is 2
        //botLeft is 3
        //botRight is 4

        //list of possible positions
        List<int> btns = new List<int> { 1, 2, 3, 4};
        //assign position of correct answer
        int position = Random.Range(1,btns.Count);
        //assign correct answer to random position and update btns
        btns = assignBtn(btns, correct, position);
        //for each incorrect answer
        for(int i = 0; i < incorrect.Length; i++)
        {
            //check if only one element left in btns
            if (btns.Count == 1)
            {
                //assign curret element to last element in btns
                assignBtn(btns, incorrect[i], btns.Count);
            }
            else
            {
                //generate new position
                position = Random.Range(1, btns.Count);
                //assign current element to position and update btns
                btns = assignBtn(btns, incorrect[i], position);
            }
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
