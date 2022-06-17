using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathDisplay : MonoBehaviour
{
    
    public int currentLives = 5;
    public Text deathText;
    
    void Update()
    {
        deathText.text = "LIVES: " + currentLives;

        
    }

   
}
