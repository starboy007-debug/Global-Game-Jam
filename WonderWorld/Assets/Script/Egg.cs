using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public static int count = 0;
    private void OnTriggerEnter()
    {
        count += 1;
        if (count == 5)
        {
            StartCoroutine(Gift());
        }
        Destroy(this.gameObject);
    }


    IEnumerator Gift()
    {
        yield return new WaitForSeconds(1.5f);
    }

}
