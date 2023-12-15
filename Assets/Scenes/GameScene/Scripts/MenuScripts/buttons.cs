using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttons : MonoBehaviour
{
   public void StarScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    public void InstructionScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
   

   public void GameClose()
    {
        Application.Quit();
    }
}
