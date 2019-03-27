using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float delaySceneTime = 3f;

    public void LoadNextScene()
    {
        // Create a variable to save the current scene index.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Have the scene manager load the next game scene by adding one to the current scene index.
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Load the very first scene in our game. Index 0 is the start game menu scene.
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    // Loads the Game Over scene.
    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    // Loads the game over scene with a delay.
    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delaySceneTime);
        SceneManager.LoadScene("Game Over");
    }

    // Allow the play the quit the game and close the applications.
    public void QuitGame()
    {
        Application.Quit();
    }
}
