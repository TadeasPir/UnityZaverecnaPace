using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorMele : MonoBehaviour
{
    public Transform Player; // Reference na hr��ovu pozici
    public float movementSpeed = 3f; // Rychlost pohybu nep��tele
    public int damage = 10; // �jma zp�soben� nep��telem hr��i

    private bool isChasing = false;

    private MeshRenderer meshRenderer;



    void Start()
    {
        // Spust�me funkci pro kontrolu hr��e ka�d�ch 0.1 sekundy
        InvokeRepeating("CheckPlayerDistance", 0, 0.1f);
        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            meshRenderer.enabled = false;
        }

    }

    void Update()
    {
        // Pokud nep��tel pron�sleduje hr��e
        if (isChasing)
        {
            // Pohneme sm�rem k hr��i
            transform.position = Vector3.MoveTowards(transform.position, Player.position, movementSpeed * Time.deltaTime);
        }
    }

    void CheckPlayerDistance()
    {
        // Vypo�teme vzd�lenost mezi hr��em a nep��telem
        float distanceToPlayer = Vector3.Distance(transform.position, Player.position);

        // Pokud je nep��tel u hr��e, zp�sobuje hr��i �jmu
        if (distanceToPlayer <= 1f)
        {
            Player.GetComponent<HealthBarScript>().TakeDamage(damage);
        }
    }
}