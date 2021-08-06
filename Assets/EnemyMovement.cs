using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMesh;
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();// navmesh componentine erişiyoruz.
        
    }

   
    void Update()
    {
        navMesh.destination = player.position;
    }
}
