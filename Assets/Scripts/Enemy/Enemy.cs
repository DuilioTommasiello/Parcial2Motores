using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Enemy : MonoBehaviour, Damagable
{
    private int Enlife = 100;

    public void TakeDmg(int dmg)
    {
        Enlife -= dmg;    
        if (Enlife <= 0)
        {
          Destroy(gameObject);
            Debug.Log("mataste un enemigo");
        }
        
    }
}
