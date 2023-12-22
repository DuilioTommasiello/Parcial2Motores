using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondMovingEnemy : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            Debug.Log("tocaste al player");
            var a = other.gameObject.GetComponent<MovmentEnemy>();
                if (a != null)
                {

                    a.nextPost++;
                }
            var b = other.gameObject.GetComponent<Player>();
            if (b != null)
            {
                b.TakeDmg(30);
                Debug.Log("te hicieron 30 de daño");
            }
        }
    }
    

}
