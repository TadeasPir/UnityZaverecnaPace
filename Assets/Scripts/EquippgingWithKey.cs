using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EquippgingWithKey : MonoBehaviour
{

    public GameObject Slot1;
    public GameObject Slot2;
    private int activeSword;
    public bool CanAttack = true;
    public float AttackCoolDown = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Equip1();
            
        }

        if (Input.GetKeyDown("2"))
        {
            Equip2();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (CanAttack && activeSword == 1)
            {
                IronSwordAttack();
            }
            if (CanAttack && activeSword == 2)
            {
                SilverSwordAttack();
            }

        }

    }
    void Equip1()
    {
        Slot1.SetActive(true);
        Slot2.SetActive(false);
        activeSword = 1;

    }
    void Equip2()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(true);
        activeSword = 2;
    }

    public void IronSwordAttack()
    {
        CanAttack = false;
        Animator anim = Slot1.GetComponent<Animator>();
        anim.SetTrigger("Utok");
        StartCoroutine(ResetCoolDown());
    }
    public void SilverSwordAttack()
    {
        CanAttack = false;
        Animator anim = Slot2.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(ResetCoolDown());
    }


    IEnumerator ResetCoolDown()
    {
        yield return new WaitForSeconds(AttackCoolDown);
        CanAttack = true;
    }
}
