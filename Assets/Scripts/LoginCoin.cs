using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginCoin : MonoBehaviour
{
    private readonly int start = Animator.StringToHash("Start");

    private Animator animator;
    private SoundManager soundManager;
    private Login loginUI;

    void Start()
    {
        loginUI = GetComponentInParent<Login>();
        soundManager = SoundManager.Instance;
        animator = GetComponent<Animator>();
    }
    public void PlaySound()
    {
        soundManager.PlaySound();
    }
    public void StartGame()
    {
        loginUI.OnClickLoginButton();
    }
    public void StartTrigger()
    {
        animator.SetTrigger(start);
    }
}
