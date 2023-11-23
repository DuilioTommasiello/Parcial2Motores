using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Player
{

    public Transform shot_point;
    public GameObject bullet;
    public GameObject ability_PB;
    public int bulletSpeed = 5;


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            bulletMove(bullet);
        } else if (Input.GetKeyUp(KeyCode.X))
        {
            bulletMove(ability_PB);
        }

    }

    public void commonAtack()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        { 
            Debug.Log("dispare");
            Instantiate(bullet, shot_point);
        }
    }  
    public void seccondAtack()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            Debug.Log("dispare la habilidad");
            Instantiate(ability_PB, shot_point);
        }
    }
    public void bulletMove(GameObject proyectile)
    {
        proyectile.transform.position = Vector2.MoveTowards(shot_point.position, shot_point.up, bulletSpeed);
        Debug.Log("dispare algo y se tiene que mover ");
    }
}
