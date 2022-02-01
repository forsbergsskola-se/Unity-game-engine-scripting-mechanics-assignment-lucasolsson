using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandController commandController;
    
    [SerializeField] private float walkSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        HandleWalking();
    }
    private void HandleWalking()
    {
        //ToDO Create movement functionality
        myRigidbody.velocity = new Vector3(commandController.walkCommand * walkSpeed, myRigidbody.velocity.y, 0);
    }
}
