using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBallController : MonoBehaviour
{
    [SerializeField] private CanonBallUI ballUI;

    private int ballsNumber;

    public int CurrentBalls => ballsNumber;

    public void SetBalls(int value)
    {
        ballsNumber = value;

        ballUI.SetCurrentBalls(ballsNumber);
    }

    public void MinusBall ()
    {
        ballsNumber--;

        ballUI.SetCurrentBalls(ballsNumber);
    }
}
