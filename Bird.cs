using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public string deathSceneName = "Last Scene"; // Bitiþ ekraný sahnesinin adý

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;

            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "DeathArea")
        {
            ShowDeathScreen();
        }
    }

    void ShowDeathScreen()
    {
        SceneManager.LoadScene(deathSceneName);
    }
    public bool isDead;

    public float velocity = 1f;

    private Rigidbody2D RB2D;

    public GameManager managerGame;
    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Tiklamayi al
        if (Input.GetMouseButtonDown(0))
        {
            //Havada kusu sicrat

            RB2D.velocity = Vector2.up * velocity;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Scorearea")
        {

            managerGame.UpdateScore();

        }

    }
   
}

   

