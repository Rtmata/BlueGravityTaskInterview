using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidBody2d;
    [SerializeField] Animator animator;

    [SerializeField] float speed;
    public Vector2 movementInput;

    public bool canMove;

    private void Awake()
    {
        canMove = true;
        rigidBody2d = GetComponent<Rigidbody2D>();
    }

    public void EnabeMovement()
    {
        canMove = true;
    }
    private void FixedUpdate()
    {
        if (canMove == true)
        {
            rigidBody2d.velocity = movementInput * speed * Time.deltaTime;
            AnimateMovement(movementInput);
        }
    }

    //Called whenever there is a change to an input bound to the Move action
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }

    private void AnimateMovement(Vector2 direction)
    {
        if (animator != null)
        {
            if(direction.magnitude > 0)
            {
                animator.SetBool("isMoving", true);
                animator.SetFloat("horizontal", direction.x);
                animator.SetFloat("vertical", direction.y);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
        }
    }
}
