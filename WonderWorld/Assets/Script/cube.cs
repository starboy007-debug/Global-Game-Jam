﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cube : MonoBehaviour
{
    public GameObject key;


    private void OnCollisionEnter()
    {
        
        StartCoroutine(Key());
    }
    IEnumerator Key()
    {
        key.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        key.SetActive(false);
    }
}
