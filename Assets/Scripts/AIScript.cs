using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Ovládá chování postavy umìlé inteligence (AI) pomocí Unity's NavMeshAgent k následování urèeného hráèe.
/// </summary>
public class AIScript : MonoBehaviour
{
    /// <summary>
    /// Transformace hráèe, kterého bude AI následovat.
    /// </summary>
    public Transform player;

    private NavMeshAgent agent;

    /// <summary>
    /// Inicializujeme komponentu NavMeshAgent.
    /// </summary>
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    /// <summary>
    /// Aktualizuje cíl NavMeshAgent na aktuální pozici hráèe.
    /// </summary>
    private void Update()
    {
        // Nastaví cíl NavMeshAgent na aktuální pozici hráèe.
        agent.destination = player.position;

        // Alternativnì lze použít metodu SetDestination:
        // agent.SetDestination(player.position);
    }
}
