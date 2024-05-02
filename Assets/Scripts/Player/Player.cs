using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
using UnityEngine.SceneManagement;
=======
using UnityEngine.Animations;
>>>>>>> Stashed changes
//Mariano Benitez
[RequireComponent(typeof(Rigidbody2D))]
public abstract  class Player : MonoBehaviour,Damagable
{
    [Header("Values")]
    [SerializeField] public int _PlayerLife = 200;
    [SerializeField] private BarLife barraDeVida;
    private Animator animaton;
<<<<<<< Updated upstream

=======
    PLayer_Move PM;
    Gamemanager ayuda;
>>>>>>> Stashed changes

    private void Start()
    {
        animaton = GetComponent<Animator>();
        barraDeVida.inicializarBarDeVia(_PlayerLife);
    }

    private void Awake()
    {
        if (!GetComponent<Rigidbody2D>())
        {
            Rigidbody2D _playerRb = gameObject.AddComponent<Rigidbody2D>();
            _playerRb.gravityScale = 0f;
        }
    }

    private void Update()
    {
        if (_PlayerLife <= 0)
<<<<<<< Updated upstream
        {
            animaton.SetTrigger("Death");
            Destroy(gameObject, 0.6f);
=======
<<<<<<< Updated upstream
        { 
            Destroy(gameObject);
=======
        {
            animaton.SetTrigger("Death");
            Destroy(gameObject, 0.5f);
            ayuda.PlayAgain();
>>>>>>> Stashed changes
>>>>>>> Stashed changes
        }
    }

    public void TakeDmg(int dmg)
    {
        _PlayerLife -= dmg;
        barraDeVida.CambiarVidaActual(_PlayerLife);
        Debug.Log("Recibí " + dmg + " de daño");

        if (_PlayerLife <= 0)
<<<<<<< Updated upstream
        {
            animaton.SetTrigger("Death");
            Destroy(gameObject, 0.6f);
        }
=======
            
            animaton.SetTrigger("Death");
        Destroy(gameObject, 0.5f);
        ayuda.PlayAgain();
>>>>>>> Stashed changes
    }


}