using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, 0, 1) * speed;
        rb.MovePosition(move);
        //     Vector3 forward = new Vector3(forward);
        // characterController.Move(Vector3 forward)
    }
}
