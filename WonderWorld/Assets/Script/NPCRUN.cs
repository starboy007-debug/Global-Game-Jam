using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRUN : MonoBehaviour
{

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedDistance = 2;
    public GameObject TheNPC;
    public float FollowSpeed;
    public RaycastHit Shot;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance >= AllowedDistance && TargetDistance<15f)
            {
                FollowSpeed = 0.1f;
             //   Vector3 direction = ThePlayer.transform.position - this.transform.position;
               // direction.y = 0;

                // TheNPC.GetComponent<Animation>().Play("Running");
                anim.SetBool("isIdle", false);
                transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed);
            }
            else
            {
                FollowSpeed = 0;
                // TheNPC.GetComponent<Animation>().Play("Idle");
                anim.SetBool("isIdle", true);
            }
        }
    }

}
