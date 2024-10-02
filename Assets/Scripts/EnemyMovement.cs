using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float changeDirectionTime;
    [SerializeField] private Vector3 direction;
    private float timer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ChangeDirection();
        Move();
    }

    private void ChangeDirection()
    {
        timer += Time.deltaTime;
        if(timer >= changeDirectionTime)
        {
            direction *= -1;
            timer = 0;
        }
    }

    private void Move()
    {
        rb.velocity= direction * speed;
    }

}
