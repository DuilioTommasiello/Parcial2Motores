using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyManager : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    GameObject destructableObjetc;
    GameObject player;
    float time;
    float DestructTime = 2f;

    private void Awake()
    {
       enemies.Add(destructableObjetc);
        player = GameObject.Find("character");
    }

    private void Update()
    {

            if(player == null)
        {
            SceneManager.LoadScene("lost");
        }

            time += Time.deltaTime;
            if(time >= DestructTime)
            {
                enemies.Remove(destructableObjetc);
                Destroy(destructableObjetc);
                time = 0;
            }
        

        if(enemies.Count == 0 && destructableObjetc == null)
        {
            SceneManager.LoadScene("Win");
        }

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6) 
        {
            if (!enemies.Contains(collision.gameObject)) 
            {
                enemies.Add(collision.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6) 
        {
            if (enemies.Contains(collision.gameObject)) 
            {
                enemies.Remove(collision.gameObject);
            }
        }
    }


}