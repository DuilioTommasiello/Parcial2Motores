using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEn : Enemy
{
    public GameObject Enbullet;
    public GameObject enemy;
    public Transform SpawnerBulletEn;
    public float TimerBull;
    public float finalTimerBull = 3;

    public override void shot()
    {
        TimerBull += Time.deltaTime;
        if (TimerBull >= finalTimerBull)
        {
            Instantiate(Enbullet, SpawnerBulletEn.position, enemy.transform.rotation);
            TimerBull = 0f;
        }
    }
}


