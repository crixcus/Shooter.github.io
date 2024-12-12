using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource mainMenuMusic;
    public AudioSource inGameMusic;
    public AudioSource HitTargetSFX;
    public AudioSource GameOverMusic;

    private void Start()
    {
        PlayMainMenuMusic();
    }

    public void PlayMainMenuMusic()
    {
        StopAllMusic();
        mainMenuMusic.Play();
    }

    public void PlayInGameMusic()
    {
        StopAllMusic();
        inGameMusic.Play();
    }

    public void ShootSFX()
    {
        HitTargetSFX.Play();
    }

    private void StopAllMusic()
    {
        mainMenuMusic.Stop();
        inGameMusic.Stop();
        HitTargetSFX.Stop();
    }

    public void GameOver()
    {
        StopAllMusic();
        GameOverMusic.Play();
    }
}
