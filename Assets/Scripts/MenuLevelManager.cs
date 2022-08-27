using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLevelManager : MonoBehaviour
{
    [SerializeField] private LevelButton[] levelButtons;

    public static PrefsValue<int> openLevels;

    private void Start()
    {
        openLevels = new PrefsValue<int>("Open level", 0);


        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i <= openLevels.Value)
            {
                levelButtons[i].SettingButton((i + 1).ToString(), true);
            }
            else
            {
                levelButtons[i].SettingButton((i + 1).ToString(), false);
            }
        }
    }

    public void LoadLevel (int level)
    {
        LevelManager.SetCurrentLevel(level);
        SceneManager.LoadScene(1);
    }
}
