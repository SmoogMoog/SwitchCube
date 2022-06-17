using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{



    float nextSpawn = 0.0f;
    float randX;
    Vector2 whereToSpawn;

    [SerializeField]
    float spawnRate = 3f;



    [SerializeField]
    GameObject enemy;

    private Transform spawnPos;
    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        
       if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-5f, 6f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
        
        
        
    }
   
}
