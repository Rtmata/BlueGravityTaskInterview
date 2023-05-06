using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidBody2d;

    [SerializeField] float speed;
    private Vector2 movementInput;
    private void Awake()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigidBody2d.velocity = movementInput * speed * Time.deltaTime;
    }

    //Called whenever there is a change to an input bound to the Move action
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }
}
