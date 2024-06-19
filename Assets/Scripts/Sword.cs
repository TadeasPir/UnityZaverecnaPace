using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private Rigidbody _body;
    public float damageOnBeasts = 10;
    public float damageOnMonsters = 2;


    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        HealthBarScript enemy = collision.GetComponent<HealthBarScript>();
        if (collision.tag == "Monster")
        {
            enemy.TakeDamage(damageOnMonsters);
            Debug.Log("enemy took damage health");
        }

        if (collision.tag == "Beast")
        {
            Debug.Log("enemy took damage health");
            enemy.TakeDamage(damageOnBeasts);
        }

    }
}
