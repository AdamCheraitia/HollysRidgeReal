using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTriggerController : MonoBehaviour
{
    public GameObject door;
    public GameObject charcater1, character2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = GameObject.Find("PlayerSprite");
            PlayerBehavior ps = player.GetComponent<PlayerBehavior>();
            Debug.Log("Talking1");
            new WaitForSecondsRealtime(5);
            Debug.Log("Talking2");
            new WaitForSecondsRealtime(5);
            Debug.Log("Talking3");
            new WaitForSecondsRealtime(5);
            Debug.Log("Talking4");
            ps.Endofscene();
            Destroy(door);
            Destroy(charcater1);
            Destroy(character2);
            Destroy(gameObject);
        }
    }
}
