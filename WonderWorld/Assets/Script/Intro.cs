using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Intro : MonoBehaviour
{
    public GameObject st1;
    // public GameObject run;
    public GameObject ohh;
    public GameObject fadein;
    public GameObject fade;
    public GameObject portal;
    public GameObject demi;
    public GameObject redScrren;
    public GameObject wlight;
    public GameObject rlight;
    void Start()
    {
        StartCoroutine(Intra());
        
    }

    IEnumerator Intra()
    {

        yield return new WaitForSeconds(1.5f);
        st1.SetActive(true);
       // Time.timeScale = 0;
        yield return new WaitForSeconds(3.5f);
        st1.SetActive(false);
     //   Time.timeScale = 1;
        yield return new WaitForSeconds(1.5f);
        fadein.SetActive(true);
        
        yield return new WaitForSeconds(1.5f);
        fadein.SetActive(false);
        fade.SetActive(true);
        //   run.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        
        fade.SetActive(false);
        //  fadein.SetActive(true);
        // portal.SetActive(true);
        yield return new WaitForSeconds(0.5f);
     
        wlight.SetActive(false);
        rlight.SetActive(true);
        portal.SetActive(true);
        yield return new WaitForSeconds(1f);
        ohh.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        ohh.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        demi.SetActive(true);
        //   run.SetActive(true);
        yield return new WaitForSeconds(3.2f);
        redScrren.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Level02");

    }
  
}
