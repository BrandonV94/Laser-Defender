using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float speedOfSpin = 1f;

    // Allows the game object to rotate continously.
    void Update()
    {
        transform.Rotate(0, 0, Random.Range(0, speedOfSpin * Time.deltaTime));
    }
}
