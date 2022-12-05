using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
    public Transform shootTransform;
    public Vector2 jumpForce = new Vector2(0, 20);
    private Rigidbody2D rb2d;
    private bool dialoge;
    public GameObject bullet;
    private float horizontal;
    private bool canJump;
    float speed = 12f;
    public GameObject bosstigger;
    BossDoorBehaviour bossdoor;

    // Start is called before the first frame update
    void Start()
    {
        dialoge = false;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (dialoge==false)
        {
            float xMove = Input.GetAxis("Horizontal");
            Vector3 position = transform.position;
            Vector3 playerPosition = position;
            playerPosition.x += xMove * Time.deltaTime * speed;
            transform.position = playerPosition;
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                Flip();
            }
            if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
            {
                rb2d.AddForce(jumpForce);
            }

            if (Input.GetMouseButtonDown(0))
            {
                shootTransform = GameObject.Find("BulletSpawn").transform;
                Instantiate(bullet, shootTransform.transform.position, shootTransform.transform.rotation);
            }
        }
        
    }

    private void FixedUpdate()
    {
        
    }

    private void Flip()
    {
        if (horizontal < 0f )
        {
            Vector3 localScale = transform.localScale;
            localScale.x = -1f;
            transform.localScale = localScale;
        }
        else if (horizontal > 0f)
        {
            Vector3 localScale = transform.localScale;
            localScale.x = 1f;
            transform.localScale = localScale;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Ground collision detection
        if(collision.gameObject.CompareTag("Ground"))
        {
            print("Collided");
           
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "CutsceneTrigger")
        {
            dialoge = true;
        }
        if(collision.gameObject.name == "bosstigger")
        {
            bossdoor.BattleStart();
            Destroy(bosstigger);
        }
        if (collision.gameObject.name == "Goalpost1")
        {
            SceneManager.LoadScene("Level2");
        }
        if (collision.gameObject.name == "Goalpost2")
        {
            SceneManager.LoadScene("Level3");
        }
        if (collision.gameObject.name == "Goalpost3")
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (collision.gameObject.name == "Goalpost4")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void Endofscene()
    {
        dialoge = false;
        print("CutsceneEnded");
    }
}
