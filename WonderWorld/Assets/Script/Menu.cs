using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
  //  public ParticleSystem snow;

    
    public void Play()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
