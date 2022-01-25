using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;

    // Update is called once per frame
    void Update()
    {
        //Get move input
        var moveInput = Input.GetAxis("Horizontal");
       //Print move input in console
       // Debug.Log("Our move input : " + moveInput);
        
        //ToDO Create movement functionality
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);

        //Get jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        
        //If we pressed the jump button: then jump
        if (jumpInput == true)
        {
              myRigidbody.AddForce(0, jumpForce, 0);
        }
    }
}
