using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsounds : MonoBehaviour
{
    public AudioSource soundPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playYeahBuddy()
    {
        soundPlayer.Play();
    }
}
