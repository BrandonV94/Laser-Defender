using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class DisplayResults : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI resultScoreText = null;
    [SerializeField] GameSession resultsGameSession = null;
    [SerializeField] Text highScoreText = null;

    // Sets the TextMeshProUGUI component to the variable scoreText.
    // Sets the GameSession object to the gameSession variable.
    void Start()
    {
        if (!GetComponent<TextMeshProUGUI>()) 
        { 
            return; 
        }
        else
        {
            resultScoreText = GetComponent<TextMeshProUGUI>();
        }
        if (!FindObjectOfType<GameSession>()) 
        {
            Debug.Log("Game Session missing!");
            return; 
        }
        else
        {
            resultsGameSession = FindObjectOfType<GameSession>();
        }
        if (!GetComponent<Text>()) 
        { 
            return;
        }
        else
        {
            highScoreText = GetComponent<Text>();
        }
    }

    // Updates the player score and sets it the scoreText field.
    void Update()
    {
        resultScoreText.text = "Score: \n" + resultsGameSession.GetScore().ToString();
        highScoreText.text = "High Score: \n" + resultsGameSession.GetHighScore().ToString();
    }
}
