using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamager : MonoBehaviour
{
    
 
    private IEnumerator damageCoroutine;
    private bool isActive = false;
    public GameObject Slot1;
  
    public bool CanAttack = true;
    public float AttackCoolDown = 1.0f;

    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            damageCoroutine = DamagePlayer(other);
            StartCoroutine(damageCoroutine);
            isActive = true;
            Debug.Log("enter");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            damageCoroutine = DamagePlayer(other);
            StopCoroutine(damageCoroutine);

            isActive = false;
            Debug.Log("exit");
        }
    }

    private IEnumerator DamagePlayer(Collider player)
    {
        while (isActive)
        {
            Animator anim = Slot1.GetComponent<Animator>();
            anim.SetTrigger("Attack");
            Debug.Log("Player took damage health");
            yield return new WaitForSeconds(AttackCoolDown);
            CanAttack = false;
          
            StartCoroutine(ResetCoolDown());
           yield return new WaitForSeconds(0.25f);
            player.GetComponent<HealthBarScriptEnemy>().TakeDamage(10f);
        }



    }

    


    IEnumerator ResetCoolDown()
    {
        yield return new WaitForSeconds(AttackCoolDown);
        CanAttack = true;
    }
}
