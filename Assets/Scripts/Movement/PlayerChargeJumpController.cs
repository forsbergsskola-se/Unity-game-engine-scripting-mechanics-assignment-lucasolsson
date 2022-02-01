using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private GroundCheckerController myGroundChecker;
    [SerializeField] private float minimumJumpForce = 100f;
    [SerializeField] private float maximumJumpForce = 1000f;
    [SerializeField] private float jumpChargeTime = 1f;
    [SerializeField] private CommandController commandController;
    private float chargeProgress = 0f;

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }
    private void HandleJump()
    {
        //Get jump input
        
        if (commandController.jumpCommand == true)
        {
            //Increase charge progress, dividing Time.deltaTime let's us control how many seconds it takes to charge a full jump.
            chargeProgress += Time.deltaTime / jumpChargeTime;
            // chargeProgress = chargeProgress + Time.deltaTime / jumpChargeTime; (same thing)
        }
        //If we release the jump button, and are ground: then jump
        if (commandController.jumpCommandUp == true)
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
