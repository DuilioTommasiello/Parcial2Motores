using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEn : Enemy
{
    public GameObject Enbullet;
    public Transform SpawnerBulletEn;
    public float TimerBull;
    public float finalTimerBull = 12;

    private void FixedUpdate()
    {
        shot();
    }

    void shot()
    {
        TimerBull += Time.deltaTime;
        if (TimerBull >= finalTimerBull)
        {
            Instantiate(Enbullet, SpawnerBulletEn.position, SpawnerBulletEn.transform.rotation);
            TimerBull = 0f;
        }
    }
}


