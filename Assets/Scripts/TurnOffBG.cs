using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffBG : MonoBehaviour
{
    private new AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("m"))
        {
            audio.Stop();
        }
    }
}
