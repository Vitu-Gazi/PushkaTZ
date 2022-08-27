using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanonBallUI : MonoBehaviour
{
    [SerializeField] private TMP_Text currentBalls;

    public void SetCurrentBalls (int newBalls)
    {
        currentBalls.text = newBalls.ToString();
    }
}
