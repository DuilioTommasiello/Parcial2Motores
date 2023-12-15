using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Player
{

    public Transform shot_point;
    public GameObject bullet;
    public GameObject ability_PB;

    public override void shoot()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("dispare");
            Instantiate(bullet, shot_point);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            Debug.Log("dispare la habilidad");
            Instantiate(ability_PB, shot_point);
        }
    }
}
