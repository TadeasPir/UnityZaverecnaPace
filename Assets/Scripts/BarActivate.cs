using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarActivate : MonoBehaviour
{
    public GameObject bars;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            bars.SetActive(true);
        }
    }
}
