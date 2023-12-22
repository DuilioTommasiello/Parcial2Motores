using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frezetime : MonoBehaviour
{
    public bool needToFreze;

    private void Update()
    {
        timefreez();
    }

    public void timefreez()
    {
        if(needToFreze == true)
        {
            Time.timeScale = 0;
        }else
        {
            needToFreze = false;    
        }
    }
}
