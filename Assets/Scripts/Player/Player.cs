using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Action<Vector2> OnMoveEvent;
    public static Action<Vector2> OnLookEvent;

    public void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>(); //�Է¹��� ���͸� �����´�.
        Debug.Log($"{(direction.x , direction.y)}");

        CallMoveEvent(direction);
    }
    public void OnLook(InputValue value)
    {
        Vector2 aimVector = value.Get<Vector2>();
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(aimVector);

        CallLookEvent(mousePosition);
    }
    private void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
    private void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
