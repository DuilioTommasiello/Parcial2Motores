using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilMove : MonoBehaviour
{
    public float speed = 5f;
    public int dmg = 40;
    public misilTracker MT;

    void Start()
    {
        GameObject misilTracker = GameObject.Find("misilTracker");
        if (misilTracker != null)
        {
            MT = misilTracker.GetComponent<misilTracker>();
        }
        else
        {
            Debug.LogError("No se pudo encontrar el objeto misilTracker");
        }
    }

    private void FixedUpdate()
    {

        if (MT != null && MT.enemyHasBeenFound == true)
        {
            if (MT.enemyList.Count > 0 && MT.enemyList[0] != null)
            {
                Vector3 targetPos = MT.enemyList[0].transform.position;
                transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.fixedDeltaTime);
            }
            else if (MT.nextEnemy < MT.enemyList.Count && MT.enemyList[MT.nextEnemy] != null)
            {
                Vector3 NextTargetPos = MT.enemyList[MT.nextEnemy].transform.position;
                transform.position = Vector3.MoveTowards(transform.position, NextTargetPos, speed * Time.fixedDeltaTime);
            }

        }
        
    }
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == 6)
            {
                Debug.Log("i collition with an enemy");
                var enemy =collision.gameObject.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDmg(dmg);
                    Destroy(gameObject);
                }
            }
            else
            {
                Debug.Log("the collition isnt Working " + collision.gameObject.layer);
            }
        }
}