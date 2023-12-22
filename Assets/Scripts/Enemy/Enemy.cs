using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, Damagable
{
    public int Enlife = 100;
    public GameObject tool;
    float previousTime;
    bool isTimeFrozen;

    public void TakeDmg(int dmg)
    {
        Enlife -= dmg;
        if (Enlife <= 0)
        {
            var numRandom = Random.Range(0, 100);
            Debug.Log(numRandom);
            if (numRandom >= 25)
            {
                Instantiate(tool, transform.position, transform.rotation);
            }
            Destroy(gameObject);
            Debug.Log("mataste un enemigo");
        }

    }
    public void FreezeTime()
    {
        if (isTimeFrozen == true)
        {
            previousTime = Time.timeScale;
            Time.timeScale = 0;
            isTimeFrozen = true;
        }
    }

    public void ResumeTime()
    {
        if (isTimeFrozen == false)
        {
            Time.timeScale = previousTime;
            isTimeFrozen = false;
        }
    }
}
