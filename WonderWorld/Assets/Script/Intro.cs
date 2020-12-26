using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Intro : MonoBehaviour
{
    public GameObject st1;
    public GameObject run;
    public GameObject fadein;
    public GameObject fade;
    void Start()
    {
        StartCoroutine(Intra());
    }

    IEnumerator Intra()
    {

        yield return new WaitForSeconds(1.5f);
        st1.SetActive(true);
       // Time.timeScale = 0;
        yield return new WaitForSeconds(2.5f);
        st1.SetActive(false);
     //   Time.timeScale = 1;
        yield return new WaitForSeconds(1.5f);
        fadein.SetActive(true);
        
        yield return new WaitForSeconds(1.5f);
        fadein.SetActive(false);
        fade.SetActive(true);
        run.SetActive(true);
        //  fadein.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        fade.SetActive(false);
        run.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Level01");

    }
    void Update()
    {
        
    }
}
