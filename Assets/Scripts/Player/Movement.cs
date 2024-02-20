using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Player _player;
    private Rigidbody2D _rigidbody2D;

    [SerializeField] 
    private float speed = 5f;

    private Vector2 moveDirection = Vector2.zero; //이동 방향

    private void Awake()
    {
        _player = GetComponent<Player>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Player.OnMoveEvent += Move;
    }
    void Update()
    {
        AdjustMove();
    }

    private void Move(Vector2 direction)
    {
        moveDirection = direction.normalized;
    }
    private void AdjustMove()
    {
        _rigidbody2D.velocity = moveDirection * speed;
    }
}
