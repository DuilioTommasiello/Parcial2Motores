using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
//Mariano Benitez y Duilio tommasiello 
=======

>>>>>>> parent of 33a21ac (menu instalado)
public class ShootEn : Enemy
{
    public GameObject Enbullet;
    public Transform SpawnerBulletEn;
    public float TimerBull;
<<<<<<< HEAD
    public float finalTimerBull = 12;

    private void Start()
    {
        Enemy.eventCall += shot;
    }
=======
    public float finalTimerBull = 3;


>>>>>>> parent of 33a21ac (menu instalado)
    public override void shot()
    {
        TimerBull += Time.deltaTime;
        if (TimerBull >= finalTimerBull)
        {
            Instantiate(Enbullet, SpawnerBulletEn.position, SpawnerBulletEn.transform.rotation);
            TimerBull = 0f;
        }
    }
}


