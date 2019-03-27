using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    // Config Param
    WaveConfig waveConfig;
    List<Transform> wayPoints;
    int wayPointIndex = 0;

    // Sets the waypoints in the wave to the variable wayPoints.
    private void Start()
    {
        wayPoints = waveConfig.GetWaypoints();
        transform.position = wayPoints[wayPointIndex].transform.position;
    }

    // Move the enemy every frame.
    private void Update()
    {
        Move();
    }

    // Set the waveConfig variable to the waveConfig parameter.
    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }

    // Determines which waypoint to move to next as the enemy goes from pont to point.
    private void Move()
    {
        if (wayPointIndex <= wayPoints.Count - 1)
        {
            var targetPosition = wayPoints[wayPointIndex].transform.position;
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards
                (transform.position, targetPosition, movementThisFrame);

            if (transform.position == targetPosition)
            {
                wayPointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
