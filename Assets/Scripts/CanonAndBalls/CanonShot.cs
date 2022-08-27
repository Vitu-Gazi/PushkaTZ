using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShot : MonoBehaviour
{
    [SerializeField] private float cooldownShoot = 0.75f;
    [SerializeField] private CanonBallController canonBall;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Ball ball;
    [SerializeField] private AudioSource shootSound;

    private Vector3 direction;
    private float currentCooldown;

    private void Start()
    {
        direction = (spawnPoint.position - transform.position).normalized;

        InputRegister.Instance.PlayerHold += Shoot;
    }
    private void OnDisable()
    {
        InputRegister.Instance.PlayerHold -= Shoot;
    }

    private void Update()
    {
        currentCooldown -= Time.deltaTime;
    }

    private void Shoot ()
    {
        if (currentCooldown > 0 || canonBall.CurrentBalls <= 0)
        {
            return;
        }

        Ball ball = Instantiate(this.ball, spawnPoint.position, Quaternion.identity);

        ball.AddForce(direction);

        LevelBallManager.Instance.AddBall(ball);

        canonBall.MinusBall();

        currentCooldown = cooldownShoot;

        shootSound.Play();
    }
}
