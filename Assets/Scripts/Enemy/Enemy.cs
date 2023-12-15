using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
//Duilio Tommasiello
=======

>>>>>>> parent of 33a21ac (menu instalado)
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
           
<<<<<<< HEAD
            Enemy.eventCall -= eventCall;
            Destroy(gameObject);
=======
            Destroy(gameObject);
            Enemy.eventCall -= eventCall;
>>>>>>> parent of 33a21ac (menu instalado)
        }
        
    }
}
