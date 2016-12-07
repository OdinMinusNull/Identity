using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float maxSpeed;

    private Rigidbody2D rb;

    void Start() {

        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {

        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * speed);

            if (rb.velocity.x > maxSpeed)
            {
                rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
            }

            if (rb.velocity.x < -maxSpeed)
            {
                rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
            }
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-Vector2.right * speed);

            if (rb.velocity.x > maxSpeed)
            {
                rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
            }

            if (rb.velocity.x < -maxSpeed)
            {
                rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * speed);

            if (rb.velocity.y > maxSpeed)
            {
                rb.velocity = new Vector2(rb.velocity.x, maxSpeed);
            }

            if (rb.velocity.y < -maxSpeed)
            {
                rb.velocity = new Vector2(rb.velocity.x, - maxSpeed);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Vector2.up * speed);

            if (rb.velocity.y > maxSpeed)
            {
                rb.velocity = new Vector2(rb.velocity.x, maxSpeed);
            }

            if (rb.velocity.y < -maxSpeed)
            {
                rb.velocity = new Vector2(rb.velocity.x, -maxSpeed);
            }
        }
    }
}﻿