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
    public GameObject fadein;

    private void Start()
    {
        StartCoroutine(Intro());
    }
    private void Update()
    {
        

        if (Egg.eggs == 1 || Egg.eggs == 3 || Egg.eggs == 4)
        {
            StartCoroutine(Gift1());
        }

        if (Egg.eggs == 2)
        {
            StartCoroutine(Gift2());
        }

        if (Egg.eggs == 5)
        {
            StartCoroutine(Gift3());
        }
        
    }
    
    IEnumerator Intro()
    {
        fadein.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        fadein.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        intro.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        intro.SetActive(false);

    }

    IEnumerator Gift1()
    {
        yield return new WaitForSeconds(1f);
        gift1.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        Egg.eggs = 0;
        gift1.SetActive(false);
    }

    IEnumerator Gift2()
    {
        yield return new WaitForSeconds(1.5f);
        gift2.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        gift2.SetActive(false);
    }

    IEnumerator Gift3()
    {
        yield return new WaitForSeconds(1.5f);
        gift3.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        gift3.SetActive(false);
    }

}
