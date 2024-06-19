using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Ovl�d� chov�n� postavy um�l� inteligence (AI) pomoc� Unity's NavMeshAgent k n�sledov�n� ur�en�ho hr��e.
/// </summary>
public class AIScript : MonoBehaviour
{
    /// <summary>
    /// Transformace hr��e, kter�ho bude AI n�sledovat.
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
    /// Aktualizuje c�l NavMeshAgent na aktu�ln� pozici hr��e.
    /// </summary>
    private void Update()
    {
        // Nastav� c�l NavMeshAgent na aktu�ln� pozici hr��e.
        agent.destination = player.position;

        // Alternativn� lze pou��t metodu SetDestination:
        // agent.SetDestination(player.position);
    }
}
