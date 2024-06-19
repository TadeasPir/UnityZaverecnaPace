using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverSword : MonoBehaviour
{
    private Rigidbody _body;
    public float damageOnBeasts = 5;
    public float damageOnMonsters = 15;

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
        }

        if (collision.tag == "Beast")
        {
            enemy.TakeDamage(damageOnBeasts);
        }

    }
}
