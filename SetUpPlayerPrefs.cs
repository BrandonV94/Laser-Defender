using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpPlayerPrefs : MonoBehaviour
{

    void Awake()
    {
        SetUpSingleton();
    }


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


    private void Start()
    {

    }

    void Update()
    {
        
    }

}
