using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {

            var b = collision.gameObject.GetComponent<Player>();
            if(b != null)
            {
                b._PlayerLife += 30;
                Debug.Log("player has been heal");
                Destroy(gameObject);

            }

        }

    }
}
