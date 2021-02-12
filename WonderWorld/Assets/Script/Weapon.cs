using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Animator anim;
    public Transform attackpoint;
    public float attackRange = 0.5f;
    public LayerMask emptylayers;
    public static bool isdie = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        anim.SetTrigger("Attack");
        Collider[] hitenemies = Physics.OverlapSphere(attackpoint.position, attackRange, emptylayers);

        foreach(Collider enemy in hitenemies)
        {
            if(enemy.name=="Zombie")
            {
                isdie = true;
                Debug.Log("zombie");
            }                
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;

        Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    }

}
