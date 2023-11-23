using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookEnemy : Enemy
{
    private void Update()
    {
        Enemy.eventCall += lookAt;
    }

    public override void lookAt()
    {
        base.lookAt();
    }

}
