using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Vector2 mouseDirection = Vector2.zero;
    private SpriteRenderer _spriteRenderer;
    private void Awake()
    {
        Player.OnLookEvent += Look;
    }
    private void Start()
    {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    private void Look(Vector2 direction)
    {
        mouseDirection = GetDirectionToMouse(direction);
        _spriteRenderer.flipX = mouseDirection.x < 0 ;
    }
    public Vector2 GetDirectionToMouse(Vector2 direction)
    {
        return (direction - (Vector2)this.transform.position).normalized;
    }
}
