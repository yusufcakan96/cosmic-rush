using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public ManagerScene mngscn;
    public void Start()
    {
        mngscn = FindObjectOfType<ManagerScene>();
    }

    public void LoadScene(int sceneNumber)
    {
        mngscn.LoadScene(sceneNumber);
    }

    public void exitGame()
    {
        mngscn.ExitGame();
    }
}
