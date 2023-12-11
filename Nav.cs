using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nav : MonoBehaviour
{
    public Transform Player;
    UnityEngine.AI.NavMeshAgent nvAgent;
    void Start()
    {
        nvAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        nvAgent.destination = Player.position;
    }
}
