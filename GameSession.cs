using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    int playerScore = 0;


    // Creates a singleton before the Start function is called.
    void Awake()
    {
        SetUpSingleton();
    }

    // Makes the GameSession game object a singleton so that it is not destroyed when a scene is loaded
    // and destroys any other GameSessions that might be created.
    private void SetUpSingleton()
    {
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

    // Returns the players score.
    public int GetScore()
    {
        return playerScore;
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
