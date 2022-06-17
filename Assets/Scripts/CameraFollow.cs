using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    Transform playerPosition;
    private GameObject playerB;
    private Vector2 offset;

    void Start()
    {
        playerB = GameObject.FindGameObjectWithTag("Player(Blue)");
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        offset.x = playerB.transform.position.x;
        transform.position = offset;
    }
}
