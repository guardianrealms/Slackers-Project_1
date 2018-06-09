using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 6.0F;
    public float jumpSpeed = 15.0F;
    public float gravity = 20.0f;

    public CharacterController controller;
    
    
    
  
  
    private Vector3 moveDirection = Vector3.zero;
  

    

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        
    }

    void Update()
    {
       
       
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection((moveDirection).normalized);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            else moveDirection.y = 0;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }


    
}
