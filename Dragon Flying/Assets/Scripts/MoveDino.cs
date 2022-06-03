using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDino : MonoBehaviour
{

    public bool isDead;
    public float karakterHizi;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public GameManager managerGame;

    public GameObject DeadScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        ProccesInputs();

    }
    void FixedUpdate()
    {
        Move();
    }
    void ProccesInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * karakterHizi, moveDirection.y * karakterHizi);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
            
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeadScreen.SetActive(true);
        }
    }

}
