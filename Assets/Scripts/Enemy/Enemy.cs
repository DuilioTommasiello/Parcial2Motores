using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour , Damagable
{
    public float Enlife;
    public float Enspeed;
    public GameObject Enbullet;
    public Transform SpawnerBulletEn, player;
    public float TimerBull, angle;
    public float finalTimerBull = 3;

    public delegate void MyMetod();
    public static event MyMetod eventCall;

    private void Update()
    {
        if (eventCall != null)
        {
            eventCall();
        }
    }
    public virtual void TakeDmg(int dmg)
    {
        Enlife -= dmg;

        if (Enlife <= 0)
            Destroy(gameObject);

    }

    public virtual void lookAt() {}
    public virtual void Patrol(){}
}
