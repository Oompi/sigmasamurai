using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control: MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed;
    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.AddForce(movement * MoveSpeed * Time.deltaTime);
    }

    
}
