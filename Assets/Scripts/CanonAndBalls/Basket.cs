using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : Singleton<Basket>
{
    [SerializeField] private BasketUI basketUI;

    private int winNumberBalls;
    private int currentBalls;

    public bool Filled => currentBalls >= winNumberBalls ? true : false;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Ball ball))
        {
            ball.AddForce(new Vector3(0.1f, -0.5f, 0));

            LevelBallManager.Instance.RemoveBall(ball);

            currentBalls++;

            basketUI.SetCurrentBalls(currentBalls);

            if (currentBalls == winNumberBalls)
            {
                LevelManager.Instance.EndLevel(true);
            }
        }
    }

    public void SetWinNumberBalls (int value)
    {
        winNumberBalls = value; 
        basketUI.SetNecessaryBalls(winNumberBalls);
    }
}
