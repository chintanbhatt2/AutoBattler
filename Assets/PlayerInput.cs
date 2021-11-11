using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    CharacterController cController;
    public Vector2 movement = Vector2.zero;
    public float jumpSpeed = 4.0f;
    public float gravity = 10f;


    void Start()
    {
        cController = GetComponent<CharacterController>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement.y = jumpSpeed;
        }



        movement.y -= gravity * Time.deltaTime;
        cController.Move(movement * Time.deltaTime);
    }


}
