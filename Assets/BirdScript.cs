using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float speed = 5f;
    GameManager gameManager;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (!gameManager.isStart)
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.gravityScale = 0;
        }
        else
        {
            rigidbody2D.gravityScale = 1;
        }

        if (transform.position.y > 5.5 || transform.position.y < -5.5)
        {
            gameManager.GameOver();

        }


        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = Vector2.up * speed;
        }
    }
}
