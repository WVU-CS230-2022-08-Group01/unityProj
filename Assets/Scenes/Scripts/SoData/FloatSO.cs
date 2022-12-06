using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
    //Preview the score value from the level of ScriptableOject reference 
    [SerializeField]

    // We can set a value inside our scrpits ScriptableOject from other scripts that refer to this scripts ScriptableOject 
    private float _value;

    public float Value 
    {
        get{ return _value;}
        set{_value = value;}
    }
}
