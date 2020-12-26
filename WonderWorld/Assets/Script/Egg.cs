using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    int count = 0;
    public static int eggs;

    private void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        count += 1;
        eggs = count;

        Destroy(this.gameObject);
    }



}
