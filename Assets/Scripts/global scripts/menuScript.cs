using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public bool pause;
    public GameObject menu;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            pause = !pause;
            menu.SetActive(pause);
        }
    }

    void Pause()
    {
        pause = !pause;
        menu.SetActive(pause);
        if(pause)
        {
            Time.timeScale = 0;
        }else
        {
            Time.timeScale = 1;
        }
    }
}
