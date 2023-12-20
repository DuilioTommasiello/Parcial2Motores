using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondMovingEnemy : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            Debug.Log("tocaste al player");
            var a = collision.gameObject.GetComponent<MovmentEnemy>();
            var b = collision.gameObject.GetComponent<Player>();
            if(b != null)
            {
                b.TakeDmg(30);
                Debug.Log("te hicieron 30 de daño"); 
                if(a != null)
                a.nextPost++;
            }
        }
    }


}
