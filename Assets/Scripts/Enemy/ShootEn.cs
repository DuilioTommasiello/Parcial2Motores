using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootEn : Enemy
{
    
    public override void lookAt()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        angle = Mathf.Atan2(directionToPlayer.y, directionToPlayer.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        TimerBull += Time.deltaTime;
        if (TimerBull >= finalTimerBull)
        {
            Instantiate(Enbullet, SpawnerBulletEn.position, transform.rotation);
            TimerBull = 0f;
        }
    }
}


