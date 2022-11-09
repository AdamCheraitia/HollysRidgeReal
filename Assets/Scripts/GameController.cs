using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject player;
    private int health;
    public GameObject heart1, heart2, heart3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
        else if (Input.GetKey(KeyCode.R))
        {
            Application.Quit();
        }
    }

    public void TakeDamage()
    {
        health--;
        if (health == 3)
        {
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }

        if (health == 2)
        {
            heart3.SetActive(false);
            heart2.SetActive(true);
        }

        if (health == 1)
        {
            heart2.SetActive(false);
        }

        if (health == 0)
        {
            heart1.SetActive(false);
            LoseALife();
        }
    }

    private void LoseALife()
    {

    }
  
}
