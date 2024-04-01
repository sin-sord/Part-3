using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 move;
    public float speed = 500;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        move.x = Input.GetAxis("Horizontal");  //  allows the player to move left and right
        move.y = Input.GetAxis("Vertical");  //  allows the player to move up and down
    }

    private void FixedUpdate()
    {
        rb.AddForce(move * speed * Time.deltaTime);  // allows the player to move using the rigidbody's movement * speed * Time.deltaTime
    }
}
