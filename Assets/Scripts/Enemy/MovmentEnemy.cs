using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentEnemy : Enemy
{
    [Header("Values")]
    public float Enspeed;
    [SerializeField] GameObject target;
    [SerializeField] List<Transform> wayPoints;
    int nextPost = 0;

    private void Start()
    {
        Enemy.eventCall += Patrol;
    }
    
    public override void Patrol()
    {
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[nextPost].transform.position, Enspeed * Time.deltaTime);
        if (transform.position == wayPoints[nextPost].transform.position)
        {
            nextPost++;
            if (nextPost >= wayPoints.Count) nextPost = 0;
        }
    }
    
}
