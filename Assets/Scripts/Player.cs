using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float jump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = FindAnyObjectByType<GameController>().jump;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jump;
        }
    }
}
