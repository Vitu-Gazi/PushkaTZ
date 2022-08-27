using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : Singleton<LevelManager>
{
    [SerializeField] private TMP_Text levelText;
    [SerializeField] private GameObject[] levels;

    private PrefsValue<int> currentLevel;

    private void Start()
    {
        currentLevel = new PrefsValue<int>("CurrentLevel", 0);

        if (currentLevel.Value >= levels.Length)
        {
            currentLevel.Value = 0;
        }

        levelText.text = "Current Level: " + (currentLevel.Value + 1).ToString();

        Instantiate(levels[currentLevel.Value]);
    }

    public void EndLevel (bool value)
    {
        if (value)
        {
            currentLevel.Value++;
        }

        EndGameController.Instance.EndGame(value);
    }
}
