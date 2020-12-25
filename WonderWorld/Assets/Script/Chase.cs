using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    //chase
    public Transform player;
    static Animator anim;
    public static bool isAttacking = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);
        if (Vector3.Distance(player.position, this.transform.position) < 15 && angle < 30)
        {
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false);
            if (direction.magnitude > 2f)
            {
                this.transform.Translate(0, 0, 0.1f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
                isAttacking = false;
            }
            else
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isAttacking", true);
                isAttacking = true;
                                
            }
        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
            isAttacking = false;
        }
    }
}
