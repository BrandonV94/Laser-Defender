using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows developers to create WaveConfigs as scritable objects.
[CreateAssetMenu(menuName = "Enemy Wave Config")] 
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

    public GameObject GetEnemyPrefab(){ return enemyPrefab; }

    // Creates a list with all the waypoints in a given WaveConfig.
    public List<Transform> GetWaypoints() 
    {
        var waveWaypoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform)
        {
            waveWaypoints.Add(child);
        }
        return waveWaypoints; 
    }

    // Returns the float timeBetweenSpawns.
    public float GetTimeBetweenSpawns() { return timeBetweenSpawns; }

    // Returns the float spawnRandomFactor.
    public float GetSpawnRandomFactor() { return spawnRandomFactor; }

    // Returns the int numberOfEnemies.
    public int GetNumberOfEnemies() { return numberOfEnemies; }

    // Returns the float moveSpeed.
    public float GetMoveSpeed() { return moveSpeed; }
}
