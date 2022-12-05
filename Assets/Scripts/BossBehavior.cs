using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    private Transform player;
    public int bosshealth;
    private int bosskilled;
    public GameObject Goal;
    BossDoorBehaviour doorcontrol;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerSprite").transform;
        bosshealth = 20;
        bosskilled = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (bosshealth == 0)
        {
            print("DEAD. NOT BIG SUPRISE");
            bosskilled++;
            Destroy(gameObject);
        }

        if (bosskilled == 4)
        {
            doorcontrol.BattleEnd();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            bosshealth --;
        }
    }
   
}
