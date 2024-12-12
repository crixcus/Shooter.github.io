using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject instruct;
    public GameObject creds;
    public MusicManager mm;

    // Start is called before the first frame update
    void Start()
    {
        instruct.SetActive(false);
        creds.SetActive(false);
        mm.PlayMainMenuMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPressed()
    {
        SceneManager.LoadScene("Space1");
    }

    public void InstructPressed()
    {
        instruct.SetActive(true);
    }

    public void CredPressed()
    {
        creds.SetActive(true);
    }

    public void backButton()
    {
        creds.SetActive(false);
        instruct.SetActive(false);
    }

    public void QuitPressed()
    {
        Debug.Log("Nagquit huhu");
        Application.Quit();
    }
}
