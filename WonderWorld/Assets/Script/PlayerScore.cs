using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{

    private void Update()
    {
        if (Egg.count == 2)
        {
            StartCoroutine(Gift1());
        }

        if (Egg.count == 5)
        {
            StartCoroutine(Gift2());
        }
    }

    IEnumerator Gift1()
    {
        yield return new WaitForSeconds(1.5f);
    }

    IEnumerator Gift2()
    {
        yield return new WaitForSeconds(1.5f);
    }

}
