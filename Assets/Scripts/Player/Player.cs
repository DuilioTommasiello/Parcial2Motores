using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
 public class Player : MonoBehaviour
 {
    [Header("Values")]
    private int _PlayerLife = 200;

    private void Awake()
    {
        if (!GetComponent<Rigidbody2D>())
        {
            Rigidbody2D _playerRb = gameObject.AddComponent<Rigidbody2D>();
            _playerRb.gravityScale = 0f;
        }
    }
    void Update()
    {
        if (_PlayerLife <= 0)
        {
            Destroy(gameObject);
        } else
        {
            movePL();
            shoot();
        }
    }
    public virtual void movePL()
    {
    }
    public virtual void shoot()
    {
    }


 }
