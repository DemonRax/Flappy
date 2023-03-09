using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameController gameController;
    Rigidbody2D rb;
    float jump;
    PhysicsMaterial2D pm;
    CircleCollider2D circleCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = FindAnyObjectByType<GameController>().jump;
        gameController = FindObjectOfType<GameController>();
        circleCollider = GetComponent<CircleCollider2D>();
        pm = circleCollider.sharedMaterial as PhysicsMaterial2D;

        circleCollider.sharedMaterial = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameController.isRunning) return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jump;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3) return;
        gameController.isRunning = false;
        circleCollider.sharedMaterial = pm;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameController.score++;
    }

}
