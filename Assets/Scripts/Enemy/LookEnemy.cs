using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookEnemy : Enemy
{

    [SerializeField]public float angle;
    [SerializeField]public Vector2 directionToPlayer;
    public Transform player;

    private void Update()
    {
        Enemy.eventCall += lookPL;

    }

    public override void lookPL()
    {
        if(player != null)
        {
        Vector3 direction = player.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 5 * Time.deltaTime);
        }
    }
    

}
