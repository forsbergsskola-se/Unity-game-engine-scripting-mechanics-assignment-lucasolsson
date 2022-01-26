using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    public float groundCheckDistance = 1f;
    public float groundCheckSphereRadius = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //We will create separete scripts for these gae mechanics, but here's an example of putting of putting the code in different methods.
        HandleMovement();
        HandleJump();
    }
    private void HandleMovement()
    {
        //Get move input
        var moveInput = Input.GetAxis("Horizontal");
        //Print move input in console
        // Debug.Log("Our move input : " + moveInput);
        
        //ToDO Create movement functionality
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);
    }
    private void HandleJump()
    {
        //Get jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        // check if we're grounded, using a raycast. Search unity raycast api if need more info
        //Vector3.down: down in world space
        //-transform.up: down in the GameObject's local space
        // var isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);

        var sphereCastRay = new Ray(transform.position, Vector3.down);
        var isGrounded = Physics.SphereCast(sphereCastRay, groundCheckSphereRadius, groundCheckDistance);

        //Draw a ray in the editor, only for visualization.
        Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.red);

        //If we pressed the jump button: then jump
        if (jumpInput == true && isGrounded == true)
        {
            //Debug.Log("Jump");
            myRigidbody.AddForce(0, jumpForce, 0);
        }
    }
    
}


