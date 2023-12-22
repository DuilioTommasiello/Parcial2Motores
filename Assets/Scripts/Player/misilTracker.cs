using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misilTracker : MonoBehaviour
{
    public int nextEnemy;
    private float alturaincial = 2f;
    public bool enemyHasBeenFound;
    public List<GameObject> enemyList = new List<GameObject>();
    public GameObject misil;

    private void FixedUpdate()
    {
        if(transform.position.y < alturaincial)
        {
            transform.Translate(Vector2.up * Time.fixedDeltaTime);
        }       
        if(misil == null)
        {
            Destroy(gameObject);
        }
        
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            Debug.Log("existe un enemigo en la zona de trackeo ");  
            enemyHasBeenFound = true;
            enemyList.Add(collision.gameObject);
            nextEnemy++;
        }
    }
}

