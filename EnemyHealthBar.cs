using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] Enemy myEnemy = null;
    [SerializeField] Slider myEnemySlider = null;

    void Start()
    {
        myEnemySlider.maxValue = myEnemy.GetHealth();
    }


    void Update()
    {
        TurnOffEnemyHealthBar();
        UpdateEnemyHealthBar();
    }

    private void UpdateEnemyHealthBar()
    {
        myEnemySlider.value = myEnemy.GetHealth();
    }

    // Makes the health bar disappear if the the slider value is less than 1
    private void TurnOffEnemyHealthBar()
    {
        if (myEnemySlider.value <= 0)
        {
            Destroy(gameObject);
        }
    }
}