using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private float time;

    private int currentPoint;

    private void Start()
    {
        MoveToPoint();
    }

    private void MoveToPoint ()
    {
        transform.DOMove(points[currentPoint].position, time).SetEase(Ease.Linear).OnComplete(() => 
        {
            currentPoint++;

            if (currentPoint >= points.Length)
            {
                currentPoint = 0;
            }

            MoveToPoint();
        });
    }
}
