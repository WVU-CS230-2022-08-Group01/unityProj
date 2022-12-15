using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchQuiz : MonoBehaviour
{
    

    //switches scenes to quiz scene when called

    public void playChapter1()
    {
        SceneManager.LoadScene(4);
    }

    public void playChapter2()
    {
        SceneManager.LoadScene(5);
    }

    public void playChapter3()
    {
        SceneManager.LoadScene(8);
    }

    public void playChapter4()
    {
        SceneManager.LoadScene(9);
    }

    public void playChapter5() {
        SceneManager.LoadScene(10);
    }

    public void playInstructions()
    {
        SceneManager.LoadScene(6);
    }

    //switches scenes to quiz select when called
    public void playSelectQuiz()
    {
        SceneManager.LoadScene(3);
    }
    //switches scenes to result scenes when called
    public void playResults ()
    {
        SceneManager.LoadScene(2);
    }
    //switches scenes to home screen when called
    public void tempBaclQuiz()
    {
        SceneManager.LoadScene(0);
    }
    //switches scenes to home screen when called
    public void playPastResults()
    {
        SceneManager.LoadScene(7);
    }
}
