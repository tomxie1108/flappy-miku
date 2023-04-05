using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public Camera mainCamera;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }

    public void dayLightCycle()
    {
        if (playerScore == 0)
        {
            mainCamera.backgroundColor = Color.black;
        }
        else if (playerScore % 20 == 0)
        {
            mainCamera.backgroundColor = Color.black;
        }
       
        
        else if (playerScore % 10 == 0)
        {
            mainCamera.backgroundColor = Color.white;
        }

    } 
    public float getScore()
    {
        return playerScore;
    }
}
