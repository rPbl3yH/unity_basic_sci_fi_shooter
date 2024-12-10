using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent NavMeshAgent;

    //Вызывается только один раз
    private void Start()
    {
        
    }

    //Вызывается каждый кадр. FPS
    private void Update()
    {
        NavMeshAgent.SetDestination(Player.position);
    }
}
