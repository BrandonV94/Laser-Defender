
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreDisplay : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameSession gameSession;

    // Sets the TextMeshProUGUI component to the variable scoreText.
    // Sets the GameSession object to the gameSession variable.
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Updates the player score and sets it the scoreText field.
    void Update()
    {
        scoreText.text = gameSession.GetScore().ToString();
    }
}
