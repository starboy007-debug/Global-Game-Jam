using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public GameObject intro;
    public GameObject gift1;
    public GameObject gift2;
    public GameObject gift3;

    private void Update()
    {
        StartCoroutine(Intro());

        if (Egg.count == 1 | Egg.count == 3 | Egg.count == 4)
        {
            StartCoroutine(Gift1());
        }

        if (Egg.count == 2)
        {
            StartCoroutine(Gift2());
        }

        if (Egg.count == 5)
        {
            StartCoroutine(Gift3());
        }
        
    }
    
    IEnumerator Intro()
    {
        yield return new WaitForSeconds(1.5f);
        intro.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        intro.SetActive(false);

    }

    IEnumerator Gift1()
    {
        yield return new WaitForSeconds(1.5f);
        gift1.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        gift1.SetActive(false);
    }

    IEnumerator Gift2()
    {
        yield return new WaitForSeconds(1.5f);
        gift2.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        gift2.SetActive(false);
    }

    IEnumerator Gift3()
    {
        yield return new WaitForSeconds(1.5f);
        gift3.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        gift3.SetActive(false);
    }

}
