using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrolling : MonoBehaviour
{
    public Transform[] waypoints;

    private int currentWaypoint = 0;
    public float followDistance = 10f;
    public float returnDistance = 15f;
    NavMeshAgent agent;

   
    private GameObject player;

    void Start()
    {
        // Set the initial position of the patroller
        transform.position = waypoints[currentWaypoint].position;

        agent = GetComponent<NavMeshAgent>();
        // Find the player object
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        // Calculate the distance to the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        float distanceToWaypoint = Vector3.Distance(transform.position, waypoints[currentWaypoint].position);

        // If the player is within the follow distance, follow the player
        if (distanceToPlayer <= followDistance)
        {
            // Move the enemy towards the player
            agent.SetDestination(player.transform.position);
        }
        // Otherwise, return to patrolling
        else if (distanceToPlayer >= returnDistance)
        {
            // Move the patroller towards the current waypoint
            agent.SetDestination(waypoints[currentWaypoint].position);

            // If the patroller has reached the current waypoint, move to the next one
            if (distanceToWaypoint <= 1)
            {
    
                currentWaypoint++;
                if (currentWaypoint == waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }
        }
    }
}
