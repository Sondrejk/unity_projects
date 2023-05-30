using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public BirdScript player;

    [ContextMenu("Increase score")]
    public void addScore(int scoreToAdd)
    {
        if (player.birdIsAlive == true) {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        }
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

}
