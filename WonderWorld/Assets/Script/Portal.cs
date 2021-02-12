using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
       // Time.timeScale = 0;
        blueScreen.SetActive(true);
        yield return new WaitForSeconds(2.2f);
        cango.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Level01");
    }

}
