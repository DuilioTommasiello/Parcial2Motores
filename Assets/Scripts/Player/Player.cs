using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Mariano Benitez
[RequireComponent(typeof(Rigidbody2D))]
public abstract  class Player : MonoBehaviour,Damagable
{
    [Header("Values")]
    [SerializeField] public int _PlayerLife = 200;
    [SerializeField] private BarLife barraDeVida;
    private Animator animaton;


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
        {
            animaton.SetTrigger("Death");
            Destroy(gameObject, 0.6f);
        }
    }

    public void TakeDmg(int dmg)
    {
        _PlayerLife -= dmg;
        barraDeVida.CambiarVidaActual(_PlayerLife);
        Debug.Log("Recibí " + dmg + " de daño");

        if (_PlayerLife <= 0)
        {
            animaton.SetTrigger("Death");
            Destroy(gameObject, 0.6f);
        }
    }


}