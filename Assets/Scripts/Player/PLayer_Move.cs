using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;



public class PLayer_Move : Player
{
    Vector2 _moveInput;
    public float _movSpeed = 0.3f;
    private Animator animator;
    private Rigidbody2D rb;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        movePL();    
    }

    void movePL()
    {
        Rigidbody2D _playerRb = gameObject.GetComponent<Rigidbody2D>();

        float moveX = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Xmovement", moveX);
        float moveY = Input.GetAxisRaw("Vertical");
        _moveInput = new Vector2(moveX, moveY).normalized;
        _playerRb.MovePosition(_playerRb.position + _moveInput * _movSpeed);
    }


}
