using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPlat : MonoBehaviour
{
    [SerializeField]
    float speed;

    GameObject deathDisplay;
    DeathDisplay deathScript;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        deathDisplay = GameObject.Find("Text");
        deathScript = deathDisplay.GetComponent<DeathDisplay>();
        player = GameObject.Find("Player(Blue)");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Ya died, bafoon");
            //player.transform.position = new Vector2(-2.141914f, -0.6776919f);
            deathScript.currentLives--;
            SceneManager.LoadScene("YouDiedScreen");


        }
    }
}
