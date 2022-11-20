using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    private Transform player;
    public int bosshealth;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerSprite").transform;
        bosshealth = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (bosshealth == 0)
        {
            print("DEAD. NOT BIG SUPRISE");
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "TempBullet")
        {
            bosshealth--;
        }
    }
   
}
