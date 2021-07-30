using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class MF_PMovement : MonoBehaviour
{
    //TODO Add Input system reference and add support for two controllers.
    [SerializeField] protected float moveSpeed = .08f;
    
    [SerializeField] protected NavMeshAgent navMeshAgent;
    protected MF_CommanderInfo info;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        info = GetComponent<MF_CommanderInfo>();
    }

    public abstract void move_pas(Vector2 moveValue);
}
