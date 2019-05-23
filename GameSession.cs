using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerScore = 0;
    [SerializeField] int highScore = 0;
    [SerializeField] Canvas gameCanvas = null;
    [SerializeField] Canvas resultsCanvas = null;

    // Creates a singleton before the Start function is called.
    void Awake()
    {
        SetUpSingleton();
    }

    // Makes the GameSession game object a singleton so that it's not destroyed when a scene is loaded
    // and destroys any other GameSessions that might be created.
    private void SetUpSingleton()
    {
        if (!FindObjectOfType<GameSession>()) { return; };
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    private void Start()
    {
        // Sets the value of highscore from the pla
        highScore = PlayerPrefs.GetInt("highScore");
    }


    private void Update()
    {
        CalculateHighScore();
        ChangeCanvas();
    }

    // Determines what the new highscore should be.
    private void CalculateHighScore()
    {
        if(playerScore > highScore)
        {
            highScore = playerScore;
        }

        Debug.Log("HighScore is " + highScore);
        PlayerPrefs.SetInt("highScore", highScore);
        PlayerPrefs.Save();
    }

    // Determines which canvas should be on during the game.
    private void ChangeCanvas()
    {
         if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            gameCanvas.gameObject.SetActive(true);
            resultsCanvas.gameObject.SetActive(false);
        }
        else
        {
            gameCanvas.gameObject.SetActive(false);
            resultsCanvas.gameObject.SetActive(true);
        }
    }
     
  
    // Returns the players score.
    public int GetScore()
    {
        return playerScore;
    }

    // Returns the value of highScore.
    public int GetHighScore()
    {
        return highScore;
    }


    // Adds the scoreValue value to the player score.
    public void AddToScore(int scoreValue)
    {
        playerScore += scoreValue;
    }

    // Destorys the GameSesssion object.
    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
