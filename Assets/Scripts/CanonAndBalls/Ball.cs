using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigid;
    [SerializeField] private float force;

    public void AddForce (Vector3 direction)
    {
        rigid.velocity = direction * force;
    }
}
