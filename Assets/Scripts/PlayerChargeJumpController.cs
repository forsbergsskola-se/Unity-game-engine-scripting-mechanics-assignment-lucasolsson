using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public GroundCheckerController myGroundChecker;
    public float minimumJumpForce = 100f;
    public float maximumJumpForce = 1000f;
    public float jumpChargeTime = 1f;

    private float chargeProgress = 0f;

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }
    private void HandleJump()
    {
        //Get jump input
        var chargeInput = Input.GetKey(KeyCode.Space);
        if (chargeInput == true)
        {
            //Increase charge progress, dividing Time.deltaTime let's us control how many seconds it takes to charge a full jump.
            chargeProgress += Time.deltaTime / jumpChargeTime;
            // chargeProgress = chargeProgress + Time.deltaTime / jumpChargeTime; (same thing)
        }
        //If we release the jump button, and are ground: then jump
        if (Input.GetKeyUp(KeyCode.Space) == true && myGroundChecker.isGrounded == true)
        {
            //Calculate jumpForce before resetting chargeProgress
            //Linear interpolation (Lerp) between miminumJumpForce and maximumJumpForce. chargeprProgress 
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, chargeProgress);
            
            chargeProgress = 0f;

            if (myGroundChecker.isGrounded == true)
            {
                //Debug.Log("Jump");
                myRigidbody.AddForce(0, jumpForce, 0);
            }
           

            
        }
    }
}
