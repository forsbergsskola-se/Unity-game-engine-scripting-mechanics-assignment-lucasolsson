using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckerController : MonoBehaviour
{
    public bool isGrounded { get; private set; }
    [SerializeField] private float groundCheckDistance = 0.6f;
    [SerializeField] private float groundCheckSphereRadius = 0.45f;
    [SerializeField] private LayerMask groundLayers;
    
   

    // Update is called once per frame
    private void Update()
    {
         CheckIfGrounded();
    }

    private void CheckIfGrounded()
    {
        // var ray = new Ray(transform.position, Vector3.down);
        // check if we're grounded, using a raycast. Search unity raycast api if need more info
        //Vector3.down: down in world space
        //-transform.up: down in the GameObject's local space
        // var isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);

        var sphereCastRay = new Ray(transform.position, Vector3.down);
        isGrounded = Physics.SphereCast(sphereCastRay, groundCheckSphereRadius, groundCheckDistance);

        //Draw a ray in the editor, only for visualization.
        Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.red);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position + Vector3.down * groundCheckDistance, groundCheckSphereRadius);
    }
}
