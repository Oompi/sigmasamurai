using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(movement * MoveSpeed * Time.deltaTime);
    }
}
