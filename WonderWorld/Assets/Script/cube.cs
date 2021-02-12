using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cube : MonoBehaviour
{
    public GameObject key;


 //   private void OnCollisionEnter()
 //   {        
 //       StartCoroutine(Key());
 //   }
    private void OnTriggerEnter()
    {
        StartCoroutine(Key());
    }
    IEnumerator Key()
    {
        key.SetActive(true);
        yield return new WaitForSeconds(1f);
        key.SetActive(false);
    }
}
