using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Enemy : MonoBehaviour, Damagable
{
    public int Enlife = 100;
    public GameObject tool;

    public void TakeDmg(int dmg)
    {
        Enlife -= dmg;    
        if (Enlife <= 0)
        {
         var numRandom = Random.Range(0, 100);
            Debug.Log(numRandom);
            if(numRandom >= 25)
            {
                Instantiate(tool);
            }
          Destroy(gameObject);
          Debug.Log("mataste un enemigo");
        }
        
    }
}
