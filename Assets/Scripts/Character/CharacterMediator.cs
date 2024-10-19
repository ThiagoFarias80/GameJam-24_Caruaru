using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CharacterMediator : MonoBehaviour
{
    private MotorController _motorController;
    private AnimationController _animationController;
    private InputController _inputController;
    private void Awake()
    {
        _motorController = GetComponent<MotorController>();
        _animationController = GetComponent<AnimationController>();
        _inputController = FindAnyObjectByType<InputController>();
    }
    private void OnEnable()
    {
        _inputController.OnMove += Move; 
    }
    private void OnDisable()
    {
        _inputController.OnMove -= Move;
    }
    private void Move(Vector2 direction)
    {
        _motorController.Move(direction);
    }

    internal void TakeDamage()
    {
        Destroy(gameObject);
    }
}
