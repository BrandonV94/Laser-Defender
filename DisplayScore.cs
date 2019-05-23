using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class DisplayScore : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText = null;
    [SerializeField] GameSession gameSession = null;

    // Sets the TextMeshProUGUI component to the variable scoreText.
    // Sets the GameSession object to the gameSession variable.
    void Start()
    {
        if (!GetComponent<TextMeshProUGUI>()) { return; };
        scoreText = GetComponent<TextMeshProUGUI>();
        if (!FindObjectOfType<GameSession>()) 
        {
            Debug.Log("Game Session missing!");
            return; 
        }
        gameSession = FindObjectOfType<GameSession>();


    }

    // Updates the player score and sets it the scoreText field.
    void Update()
    {
        scoreText.text = "Score: \n" + gameSession.GetScore().ToString();
    }
}
