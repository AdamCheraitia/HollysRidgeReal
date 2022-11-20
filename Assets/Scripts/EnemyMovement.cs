using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] PatrolPoint;
    public int Point;
    public float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Point == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, PatrolPoint[0].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, PatrolPoint[0].position) < 0.2f)
            {
                Point = 1;
            }
        }

        if (Point == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, PatrolPoint[1].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, PatrolPoint[1].position) < 0.2f)
            {
                Point = 0;
            }
        }
    }
}
