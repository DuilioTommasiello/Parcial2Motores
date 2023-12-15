using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Duilio Tommasiello
public abstract class  Enemy : MonoBehaviour, Damagable
{
    private int Enlife = 100;

    public delegate void MyMetod();
    public static event MyMetod eventCall;

    private void Update()
    {
        if (eventCall != null)
        {
            eventCall();
        }
        
    }
    public virtual void shot(){}
    public virtual void lookPL(){}
    public virtual void Patrol(){}
    public void TakeDmg(int dmg)
    {
        Enlife -= dmg;
        Debug.Log("holaa");
    
        if (Enlife <= 0)
        {
           
            Enemy.eventCall -= eventCall;
            Destroy(gameObject);
        }
        
    }
}
