using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipReached : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject uiPanel;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D (Collider2D touch)
    {
        if (touch.gameObject.CompareTag("Ship"))
        {
            Time.timeScale = 0;
            winScreen.SetActive(true);
            uiPanel.SetActive(false);
        }
    }

    public void nextStage()
    {
        SceneManager.LoadScene("Space2");
    }
}
