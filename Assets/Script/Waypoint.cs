using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Waypoint : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;

    public float distansPatrol;
    public float stopPursuit;
    public float speed;

    public Transform[] waypoints;
    public Transform player;

    int _CurrentWaypointIndex;

    bool _patrol = false;
    bool _pursuit = false;

    void Start()
    {
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, waypoints[_CurrentWaypointIndex].position) < distansPatrol && _pursuit == false)
        {
            _patrol = true;
        }

        if (Vector3.Distance(transform.position, player.position) < stopPursuit)
        {
            _pursuit = true;
            _patrol = false;
        }

        if (Vector3.Distance(transform.position, player.position) > stopPursuit)
        {
            _pursuit = false;
        }

        if (_patrol)
        {
            Patrol();
        }
        else if(_pursuit)
        {
            Pursuit();
        }
    }

    void Patrol ()
    {
       if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            _CurrentWaypointIndex = (_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[_CurrentWaypointIndex].position);
        }
    }

    void Pursuit()
    {
        speed = speed + 0.02f;
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        transform.LookAt(player);
    }
}
