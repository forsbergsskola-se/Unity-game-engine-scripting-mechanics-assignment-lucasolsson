using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        HandleWalking();
    }
    private void HandleWalking()
    {
        //Get move input
        var moveInput = Input.GetAxis("Horizontal");
        //Print move input in console
        // Debug.Log("Our move input : " + moveInput);
        
        //ToDO Create movement functionality
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);
    }
}
