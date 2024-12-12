using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen2 : MonoBehaviour
{
    public GameObject ggPanel;
    public GameObject uiPanel;

    public void ggScreen()
    {
        Time.timeScale = 0;
        ggPanel.SetActive(true);
        uiPanel.SetActive(false);
    }

    public void AgainButton()
    {
        ggPanel.SetActive(false);
        uiPanel.SetActive(true);
        SceneManager.LoadScene("Space2");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
