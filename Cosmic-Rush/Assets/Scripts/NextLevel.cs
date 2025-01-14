using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public ManagerScene mngscn;
    public int totalScenesToComplete = 3;
    private int currentSceneIndex;

    void Start()
    {
        mngscn = FindObjectOfType<ManagerScene>();
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (currentSceneIndex == totalScenesToComplete)
            {
                mngscn.StopTimer();
                SceneManager.LoadScene(totalScenesToComplete + 1);
            }
            else
            {
                mngscn.UnlockNextPlanet();
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }
}