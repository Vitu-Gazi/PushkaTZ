using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BasketUI : MonoBehaviour
{
    [SerializeField] private TMP_Text necessaryBalls;
    [SerializeField] private TMP_Text currentBalls;

    public void SetNecessaryBalls(int newBalls)
    {
        necessaryBalls.text = "/ " + newBalls.ToString();
    }
    public void SetCurrentBalls(int newBalls)
    {
        currentBalls.text = newBalls.ToString();
    }
}
