using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Player
{
    public Transform shot_point;
    public GameObject bullet;
    public GameObject ability_PB;

    private float shootCooldown = 0.5f;
    private float SecondShootCooldown = 2f;
    private float shootTimer = 0f;

    private void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.Space) && shootTimer <= 0)
        {
            ShootBullet();
        }

        if (Input.GetKey(KeyCode.X) && shootTimer <= 0)
        {
            UseAbility();
        }
    }

    private void ShootBullet()
    {
        Instantiate(bullet, shot_point.position, shot_point.rotation);
        shootTimer = shootCooldown; 
    }

    private void UseAbility()
    {
        Instantiate(ability_PB, shot_point.position, shot_point.rotation);
        shootTimer = SecondShootCooldown; 
    }
}
