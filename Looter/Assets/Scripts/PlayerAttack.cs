using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private PlayerSC _playerSC;

    private PlayerInput _playerInput;
    private InputAction _attackAction;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _attackAction = _playerInput.actions["Attack"];
    }

    private void OnEnable()
    {
        _attackAction.performed += _ => StartAttack();
        _attackAction.canceled += _ => CancelAttack();
    }

    private void OnDisable()
    {
        _attackAction.performed -= _ => StartAttack();
        _attackAction.canceled -= _ => CancelAttack();
    }

    private void StartAttack()
    {
        _playerSC.Attack();
    }

    private void CancelAttack()
    {
        return;
    }
}
