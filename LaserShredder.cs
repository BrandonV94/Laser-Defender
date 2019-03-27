using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShredder : MonoBehaviour
{
    // Destroys any lasers that come into contact with the Laser Shredder game object.
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
