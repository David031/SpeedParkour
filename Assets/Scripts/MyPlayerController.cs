using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;
    private bool groundedPlayer;
    private float movementSpeed = 2.0f;
    private float rotationSpeed = 2.0f;
    private float JumpSpeed = 1.0f;
    private float gravity = -9.81f;

    private Vector3 movementDirectiom = Vector3.zero;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void update()
    { //movement
        Vector3 inputMovement = transform.forward * movementSpeed * Input.GetAxisRaw("Vertical");
        characterController.Move(inputMovement * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * rotationSpeed);
        //Jumping
        if (Input.GetButton("Space") && characterController.isGrounded) 
        {
            movementDirectiom.y= JumpSpeed; 
        }
        movementDirectiom.y -= gravity * Time.deltaTime; 

characterController.Move(movementDirectiom * Time.deltaTime);
        //animations
        animator.SetBool("isRunning", Input.GetAxisRaw("Vertical")!=0);
            animator.SetBool("isJump",!characterController.isGrounded);      
            }
    }