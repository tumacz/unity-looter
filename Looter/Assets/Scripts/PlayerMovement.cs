using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Rigidbody2D _rb;
    private Transform _cameraTransform;
    private InputAction _moveAction;

    private Vector2 _currentInputVector;
    private Vector2 _smoothInputVelocity;
    private Vector2 _moveVector;


    [SerializeField] private PlayerSC _playerSC;

    private void Awake()
    {
        GetReferences();
        _playerSC.ResetValues();
    }

    private void Update()
    {
        CalculateMovement();
    }

    private void FixedUpdate()
    {
        ExecuteMovement();
    }

    private void CalculateMovement()
    {
        Vector2 moveInput = _moveAction.ReadValue<Vector2>();
        _currentInputVector = Vector2.SmoothDamp(_currentInputVector,moveInput, ref _smoothInputVelocity, _playerSC.smoothInputSpeed);
        _moveVector = (_currentInputVector.x * _cameraTransform.right.normalized + _currentInputVector.y * _cameraTransform.up.normalized);
        _playerSC.playerPos = _cameraTransform.position;
    }

    private void ExecuteMovement()
    {
        _rb.gameObject.transform.Translate(_moveVector * Time.deltaTime * _playerSC.playerSpeed);
    }



    private void GetReferences()
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];

        _rb = GetComponent<Rigidbody2D>();
        _cameraTransform = Camera.main.transform;
    }
}
