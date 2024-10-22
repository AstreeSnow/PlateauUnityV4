using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    [SerializeField] private GameObject target;
    
    private NavMeshAgent _agent;
    private Animator _animator;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(target.transform.position);
        _animator = GetComponent<Animator>();
    }
}

private void Update ()
{
    _animator.SetFloat(name: "Speed",_agent.velocity.magnitude);

}
