using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_Move : Player
{
    Vector2 _moveInput;
    public float _movSpeed = 0.3f;


    public override void movePL()
    {
        Debug.Log("se esta moviendo");
        Rigidbody2D _playerRb = gameObject.GetComponent<Rigidbody2D>();

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        _moveInput = new Vector2(moveX, moveY).normalized;

        _playerRb.MovePosition(_playerRb.position + _moveInput * _movSpeed);
    }


}
