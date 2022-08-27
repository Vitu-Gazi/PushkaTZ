using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text levelText;

    public void SettingButton (string levelIndex, bool buttonInteractive)
    {
        levelText.text = levelIndex;
        button.interactable = buttonInteractive;
    }
}
