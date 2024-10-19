using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public Action<Vector2> OnMove;
    private GameInputs _gameInputs;

    private void Awake()
    {
        _gameInputs = new GameInputs();
        _gameInputs.Enable();
        _gameInputs.Gameplay.Move.performed += Move;
    }

    private void Move(InputAction.CallbackContext ctx)
    {
        var direction = ctx.ReadValue<Vector2>();
        OnMove?.Invoke(direction);
    }
}