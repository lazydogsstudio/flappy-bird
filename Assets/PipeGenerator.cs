using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipe;
    public Transform[] instancePosition;

    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        InvokeRepeating("pipeGenerator", 2.0f, 2f);
    }

    void pipeGenerator()
    {
        if (gameManager.isStart)
        {
            int randomRange = Random.Range(0, 2);

            GameObject o = Instantiate(pipe, instancePosition[randomRange].position, Quaternion.identity);

            if (randomRange == 0)
                o.transform.localScale = new Vector3(2, Random.Range(-3f, -1f), 1);
            else
            {
                o.transform.localScale = new Vector3(2, Random.Range(1f, 3f), 1);
            }
        }
    }



}
