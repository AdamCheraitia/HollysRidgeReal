using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDoorBehaviour : MonoBehaviour
{
    public float speed = 8f;
    public Transform[] doorPosition;
    public int doorState;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BattleStart()
    {
        transform.position = Vector2.MoveTowards(transform.position, doorPosition[0].position, speed * Time.deltaTime);
    }

    public void BattleEnd()
    {
        transform.position = Vector2.MoveTowards(transform.position, doorPosition[1].position, speed * Time.deltaTime);
    }
   
}
