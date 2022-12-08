using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class StudyUrl : MonoBehaviour
{
    public void OpenURL()
    {
        UnityEngine.Application.OpenURL("https://drive.google.com/drive/u/2/folders/1JiU0XvcK2t9tXlTQt0uOTYmnHeMyLo2n");
        UnityEngine.Debug.Log("is this working?");
    }

}
