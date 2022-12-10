using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text scoretext;
    public GameObject gameOverScreen;
    [ContextMenu("Increase Score")]
    public void addScore(int ScoreToAdd)
    {
        PlayerScore = PlayerScore + ScoreToAdd;
        scoretext.text = PlayerScore.ToString();

    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void gameOver() 
    {
        gameOverScreen.SetActive(true);
        
    }

}
