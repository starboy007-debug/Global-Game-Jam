using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class R1Zombie : MonoBehaviour
{
    public GameObject die;
    void OnTriggerEnter()
    {
        Debug.Log("margaya");
        StartCoroutine(Margaya());
    }

    IEnumerator Margaya()
    {
        yield return new WaitForSeconds(0.5f);
        die.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Level02");
    }

}
