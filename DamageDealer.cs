using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int damage = 100;

    // Returns the int damage.
    public int GetDamage()
    {
        return damage;
    }

    // Destroys the gameObject that is hit by a laser.
    public void Hit()
    {
        Destroy(gameObject);
    }


}
