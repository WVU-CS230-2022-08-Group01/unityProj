using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsLogControl : MonoBehaviour
{
    //Initialize object for result text
    [SerializeField]
    private GameObject textTemplate;

    //Initialize list to store results
    [SerializeField]
    private List<string> results;

    //function for logging results in log box in PastResults scene
    public void LogResult(string result)
    {
        //Create new result object
        GameObject newResult = Instantiate(textTemplate) as GameObject;
        newResult.SetActive(true);

        //Set result object to result
        newResult.GetComponent<ResultLogItem>().SetResult(result);
        newResult.transform.SetParent(textTemplate.transform.parent, false);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Create file reader and read file from results
        FileReading FileReader = new FileReading();
        results = FileReader.ReadResults("results.txt");

        //For each result in list of results, log the result in log box
        foreach (string result in results)
        {
            LogResult(result);
        }
    }
}
