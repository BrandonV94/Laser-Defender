using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayHealth : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] Player player;

    // Sets the TextMeshProUGUI component to the variable healthText.
    // Sets the Player gameObject to the variable player.
    void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<Player>();
    }

    // Displays the players current in the healthText field.
    void Update()
    {
        healthText.text = "Health: " + player.GetHealth().ToString();
    }
}
