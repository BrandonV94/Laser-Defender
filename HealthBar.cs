using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Player myPlayer = null;
    [SerializeField] Slider mySlider = null;

    void Start()
    {
        mySlider.maxValue = myPlayer.GetHealth();
    }


    void Update()
    {
        TurnOffHealthBar();
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        mySlider.value = myPlayer.GetHealth();
    }

    // Makes the health bar disappear if the the slider value is less than 1
    private void TurnOffHealthBar()
    {
        if (mySlider.value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
