using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;
    private Transform _transform;

    public float Speed => _speed;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        Move();
    }
    
    public void SetMoveSpeed(float speed)
    {
        _speed = speed;
    }

    private void Move()
    {
        Vector2 velocity = new Vector2(_speed, 0);
        _rigidbody.velocity = velocity;
    }
}
