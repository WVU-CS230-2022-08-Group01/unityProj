using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsLogControl : MonoBehaviour
{
    [SerializeField]
    private GameObject textTemplate;

    [SerializeField]
    private List<string> results;

    public void LogResult(string result)
    {
        GameObject newResult = Instantiate(textTemplate) as GameObject;
        newResult.SetActive(true);

        newResult.GetComponent<ResultLogItem>().SetResult(result);
        newResult.transform.SetParent(textTemplate.transform.parent, false);
    }

    // Start is called before the first frame update
    void Start()
    {
        FileReading FileReader = new FileReading();
        results = FileReader.ReadResults("results.txt");
        foreach (string result in results)
        {
            Debug.Log(result);
            LogResult(result);
        }
    }
}
