using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    float moveSpeed = 0.02f;
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (gameManager.isStart)
            transform.Translate(Vector3.left * moveSpeed);
        if (transform.position.x < -5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            gameManager.GameOver();
        }
    }
}
