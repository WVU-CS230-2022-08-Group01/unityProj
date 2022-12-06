using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameValues : MonoBehaviour
{
    private void Start(){
        FindObjectOfType<PointSystem>().SetPoint(0);
    }
}
