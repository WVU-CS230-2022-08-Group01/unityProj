using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

//Static class for storing name of chapters being completed for use with FileWriter to write results to file
public static class QuizName
{
    //Create static string chapter to store chapter name across scenes
    public static string chapter { get; set; }
}
