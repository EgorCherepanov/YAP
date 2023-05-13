using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed = 5f;
    float dirX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 10f;
        }
        else 
        {
            moveSpeed = 5f;
        }
        dirX = Input.GetAxis("Horizontal") * moveSpeed;

        
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }
}
