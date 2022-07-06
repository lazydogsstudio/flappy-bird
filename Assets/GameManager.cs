using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public GameObject gameOverUI, gameStartUI, gamePlayUI;
    public Text scoreText, gameOverScoreText;
    public bool isStart;

    float score;

    public void StartGame()
    {
        gameStartUI.SetActive(false);
        gamePlayUI.SetActive(true);
        isStart = true;

    }

    public void GameOver()
    {
        isStart = false;
        gameOverUI.SetActive(true);
        gamePlayUI.SetActive(false);

    }

    public void ReStart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void Update()
    {
        int jScore = (int)score;
        scoreText.text = jScore.ToString();
        gameOverScoreText.text = jScore.ToString();
    }

    private void FixedUpdate()
    {
        if (isStart)
            score += 0.2f;
    }
}
