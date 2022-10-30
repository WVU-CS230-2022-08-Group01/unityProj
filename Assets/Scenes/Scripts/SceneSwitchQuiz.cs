using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchQuiz : MonoBehaviour
{
    public void playQuiz() {
        SceneManager.LoadScene(1);
    }
    public void tempBaclQuiz()
    {
        SceneManager.LoadScene(0);
    }
}
