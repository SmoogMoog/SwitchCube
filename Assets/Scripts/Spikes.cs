using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    
    GameObject player;
    Scene myScene;
    public static string sceneName;

    void Start()
    {
        
        player = GameObject.Find("Player(Blue)");
        myScene = SceneManager.GetActiveScene();
        sceneName = myScene.name;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Ya died, bafoon");
            //player.transform.position = new Vector2(-2.141914f, -0.6776919f);
            
            SceneManager.LoadScene(sceneName);

        }
            
        
    }
}
