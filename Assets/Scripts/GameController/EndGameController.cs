using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameController : Singleton<EndGameController>
{
    [SerializeField] private GameObject winPanel;

    private bool isWin;

    public Action EndGameEvent;

    public void EndGame (bool value)
    {
        EndGameEvent?.Invoke();

        if (isWin != default)
        {
            return;
        }

        isWin = value;

        if (isWin)
        {
            winPanel.SetActive(true);
        }
        else
        {
            Restart();
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
