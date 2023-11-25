using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour , Damagable
{
    private float Enlife = 100;

    public delegate void MyMetod();
    public static event MyMetod eventCall;

    private void Update()
    {
        if (eventCall != null)
        {
            eventCall();
        }
        shot();
    }
    public virtual void TakeDmg(int dmg)
    {
        Enlife -= dmg;

        if (Enlife <= 0)
            Destroy(gameObject);

    }
    public virtual void shot(){}
    public virtual void lookPL(){}
    public virtual void Patrol(){}
}
