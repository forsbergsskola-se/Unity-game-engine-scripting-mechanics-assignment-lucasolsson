using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private GroundCheckerController myGroundChecker;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private PlayerInputController playerInputController;

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }
    private void HandleJump()
    {
        //Get jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //If we pressed the jump button: then jump
        if (playerInputController.jumpInputDown == true && myGroundChecker.isGrounded == true)
        {
            //Debug.Log("Jump");
            myRigidbody.AddForce(0, jumpForce, 0);
        }
    }
}
