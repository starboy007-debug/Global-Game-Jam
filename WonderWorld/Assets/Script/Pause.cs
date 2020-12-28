using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            pausePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0;
        }

    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
