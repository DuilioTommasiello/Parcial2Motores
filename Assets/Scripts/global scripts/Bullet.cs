using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
 public class Bullet : MonoBehaviour
 {
    public int bulletdmg = 30;
    public int speed = 10;
    private Rigidbody2D rb;
    public bool CharacterBullet = false;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
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
            var a = collision.gameObject.GetComponent<Player>();
            if (a == null)
            {
                Debug.Log("No detecta el player ");
            }else
            {
                a.TakeDmg(bulletdmg / 2);
            }
            Destroy(gameObject);

        }
        if (collision.gameObject.gameObject.layer == 6 && CharacterBullet == true)
        {
            var b = collision.gameObject.GetComponent<Enemy>();
            if (b == null)
            {
                Debug.Log("No detecta el enemigo ");
            }else
            {
                b.TakeDmg(bulletdmg);
            }
            Debug.Log("tocaste un enemigo y le hiciste" +  bulletdmg); 
            Destroy(gameObject);


        }
    }



 }
