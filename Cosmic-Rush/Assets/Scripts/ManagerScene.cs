using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private float startTime;
    private float elapsedTime;
    private bool finishOnce;
    private string startOver;

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadSceneAsync(sceneNumber);
        if (sceneNumber == 1)
        {
            StartTimer();
            startOver = "Oyunu bitirdin! Tebrikler!";
        }
        else if (sceneNumber == 0)
        {
            startTime = 0.0f;
            elapsedTime = 0.0f;
            startOver = "Lütfen oyuna 1. seviyeden baþla!";
        }
    }

    public void StartTimer()
    {
        startTime = Time.time;
    }

    public void StopTimer()
    {
        elapsedTime = Time.time - startTime;
    }

    public float GetElapsedTime()
    {
        return elapsedTime;
    }

    public string StartOver()
    {
        return startOver;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void UnlockNextPlanet()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedPlanets", PlayerPrefs.GetInt("UnlockedPlanets", 1) + 1);
            PlayerPrefs.Save();
        }
    }
}
