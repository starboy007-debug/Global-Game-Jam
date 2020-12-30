using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject cango;
    public GameObject blueScreen;


    private void OnTriggerEnter()
    {
        StartCoroutine(Blue());
    }

    IEnumerator Blue()
    {
        blueScreen.SetActive(true);
        yield return new WaitForSeconds(2.2f);
        cango.SetActive(true);
    }

}
