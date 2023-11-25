using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
 public class Bullet : MonoBehaviour
 {
    int BulletDmg;
    public int speed = 10;
    private Rigidbody2D rb;
    public bool CharacterBullet = false;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        Destroy(gameObject, 1.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.gameObject.layer == 3 && CharacterBullet == false)
        {
            Debug.Log("tocaste un pj");
            Destroy(gameObject);
        }
        if (collision.gameObject.gameObject.layer == 6 && CharacterBullet == true)
        {
            Debug.Log("tocaste un enemigo");
            Destroy(gameObject);
        }
    }


 }
