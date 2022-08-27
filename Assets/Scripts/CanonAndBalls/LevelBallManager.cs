using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBallManager : Singleton<LevelBallManager>
{
    [SerializeField] private CanonBallController canonBall;
    [SerializeField] private Basket basket;
    [SerializeField] private int canonBallsNumber;
    [SerializeField] private int basketBallsNumber;

    private List<Ball> balls = new List<Ball>();

    private void Start()
    {
        canonBall.SetBalls(canonBallsNumber);
        basket.SetWinNumberBalls(basketBallsNumber);
    }

    public void AddBall(Ball ball)
    {
        balls.Add(ball);
    }

    public void RemoveBall (Ball ball)
    {
        balls.Remove(ball);

        if (canonBall.CurrentBalls <= 0 && !basket.Filled)
        {
            LevelManager.Instance.EndLevel(false);
        }
    }
}
