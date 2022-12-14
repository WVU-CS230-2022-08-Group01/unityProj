using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class QuizName
{
    public static string chapter { get; set; }
/*    public static QuizName Instance;
    public string chapter;
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Chapter1" || sceneName == "Chapter2" || sceneName == "Chapter5")
        {
            chapter = sceneName;
        }
    }

    public string returnChapter()
    {
        return chapter;
    }

    public void destroyInstance()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
    }*/
}
