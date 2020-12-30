using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public GameObject intro;
    public GameObject fadein;
    public GameObject gift1;
    public GameObject gift2;
    public GameObject gift3;
    public GameObject portal;
    public GameObject portalcube;
    public GameObject portalcube1;

    //   int count = 0;
    public static int eggs = 0;
    private void Start()
    {
        StartCoroutine(Intro());
        // Gifts();
    }
    private void Update()
    {
        // Gifts();
    }

    public void Gifts()
    {
        if (eggs == 1 || eggs == 3 || eggs == 4)
        {
            StartCoroutine(Gift1());
        }

        if (eggs == 2)
        {
            StartCoroutine(Gift2());
        }

        if (eggs == 5)
        {
            StartCoroutine(Gift3());
        }
    }

    IEnumerator Intro()
    {
        fadein.SetActive(true);       
        yield return new WaitForSeconds(3f);
        intro.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        intro.SetActive(false);

    }


    IEnumerator Gift1()
    {
        yield return new WaitForSeconds(1f);
        gift1.SetActive(true);
        Debug.Log("gift1 work");
        yield return new WaitForSeconds(2.5f);
        //  Egg.eggs = 0;
        gift1.SetActive(false);
    }

    IEnumerator Gift2()
    {
        yield return new WaitForSeconds(1.5f);
        gift2.SetActive(true);
        Debug.Log("gift2 work");
        portal.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        gift2.SetActive(false);
    }

    IEnumerator Gift3()
    {
        yield return new WaitForSeconds(1.5f);
        gift3.SetActive(true);
        Debug.Log("gift3 work");
        portal.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        gift3.SetActive(false);
        portalcube.SetActive(false);
        portalcube1.SetActive(false);
    }

}
