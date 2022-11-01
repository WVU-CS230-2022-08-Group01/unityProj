using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchQuiz : MonoBehaviour
{
    //switches scenes to quiz scene when called
    public void playQuiz() {
        SceneManager.LoadScene(1);
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
}
