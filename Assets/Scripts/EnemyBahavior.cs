using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBahavior : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask groundLayer;
    public LayerMask playerLayer;
    public Vector3 walkPoint;

    //Vìci pro patrolování
    bool walkPointSet;
    public float walkPointRange;

    //Èas mezi útoky
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //Parametry na odmìøení vzdálenosti
    public float sightRange;
    public float attackRange;
    public bool playerInSight;
    public bool playerInAttack;


    public void OnPostRender()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }





    void Update()
    {
        //Koukneme se po hráèi, jestli je vidìt, nebo jestli se na nìj dá zaútoèit
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);
        playerInAttack = Physics.CheckSphere(transform.position, attackRange, playerLayer);

        if (!playerInSight && !playerInAttack) Patrolovani();
        if (playerInSight && !playerInAttack) Patrolovani();
        if (playerInSight && playerInAttack) Utoceni();

    }

    private void Patrolovani ()
    {
        if (!walkPointSet) vyhledatCestu();
        if (walkPointSet)
        {
            agent.SetDestination(walkPoint);
        }
        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.magnitude < 1f) 
        {
            walkPointSet = false;

        }
    }

    public void vyhledatCestu()
    {
        float Z = Random.Range(-walkPointRange, walkPointRange);
        float X = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + X, transform.position.y, transform.position.z + Z);

        if(Physics.Raycast(walkPoint, -transform.up, 2f, groundLayer)) 
        {
            walkPointSet = true;
        }
    }
    private void Pronasledovani()
    {
        agent.SetDestination(player.position);
    }
    private void Utoceni()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        if(!alreadyAttacked)
        {
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;

    }


   
}
