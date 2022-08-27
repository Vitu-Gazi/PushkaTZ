using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ball ball))
        {
            LevelBallManager.Instance.RemoveBall(ball);
            Destroy(ball.gameObject);
        }
    }
}
