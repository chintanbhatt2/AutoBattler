using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Rigidbody2D rBody;
    public Vector2 movement = Vector2.zero;
    public float jumpSpeed = 10.0f;
    public float moveSpeed = 0.01f;


    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement.y = jumpSpeed;
            rBody.AddForce(movement, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rBody.position += new Vector2(moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rBody.position += new Vector2(-moveSpeed, 0);
        }


    }


}
