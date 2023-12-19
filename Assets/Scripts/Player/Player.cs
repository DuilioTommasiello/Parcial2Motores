using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Mariano Benitez
[RequireComponent(typeof(Rigidbody2D))]
public abstract  class Player : MonoBehaviour,Damagable
{
    [Header("Values")]
    [SerializeField] private int _PlayerLife = 200;
    [SerializeField] private BarLife barraDeVida;

    private void Start()
    {
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
    void Update()
    {
        if (_PlayerLife <= 0)
            Destroy(gameObject);               
    }

    public void TakeDmg(int dmg)
    {
        _PlayerLife -= dmg;
        barraDeVida.CambiarVidaActual(_PlayerLife);
        Debug.Log("recibi "+ dmg + " de daño");

        if (_PlayerLife <= 0)
            Destroy(gameObject);
    }
}
