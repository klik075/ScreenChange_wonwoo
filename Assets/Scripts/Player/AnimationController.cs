using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private readonly int runParameter = Animator.StringToHash("Run"); 
    Animator animator;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        Player.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        animator.SetBool(runParameter, direction.magnitude > 0.5f);
    }
}
