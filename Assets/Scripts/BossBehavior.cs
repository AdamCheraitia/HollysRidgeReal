using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    private Transform player;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerSprite").transform;
        health = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            print("DEAD. NOT BIG SUPRISE");
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "TempBullet")
        {
            health--;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerSprite")
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), 8f * Time.deltaTime);
        }
    }
}
