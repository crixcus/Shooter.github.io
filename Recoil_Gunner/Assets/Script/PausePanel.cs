using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject instructpanel;
    public GameObject uiPanel;

    void Update()
    {
        
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        uiPanel.SetActive(false);

        Time.timeScale = 0;
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        uiPanel.SetActive(true);
        Time.timeScale = 1;
    }

    public void Instructions()
    {
        instructpanel.SetActive(true);
    }

    public void backButton()
    {
        instructpanel.SetActive(false);
        pausePanel.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
