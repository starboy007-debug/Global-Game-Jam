using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRun : MonoBehaviour
{
    public Transform player;
    float rotspeed = 2.0f, movespeed = 3.0f;


    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position, transform.position), rotspeed * Time.deltaTime);

        transform.position += transform.forward * movespeed * Time.deltaTime;
    }
}
