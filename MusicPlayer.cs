using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Calls the SetUpSingleton() function as soon as the script is run.
    void Start()
    {
        SetUpSingleton();
    }

    // Determines if there is a Music Player game object is in the scene and destroys 
    // any other objects with the same name.
    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
