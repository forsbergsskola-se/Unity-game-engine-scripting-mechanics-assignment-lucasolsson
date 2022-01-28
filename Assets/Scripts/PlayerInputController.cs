using System;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float walkInput { get; private set; }
    public bool jumpInput { get; private set; }
    public bool jumpInputDown { get; private set; }
    public bool jumpInputUp { get; private set; }
    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        //get move input
        walkInput = Input.GetAxis("Horizontal");
        
        jumpInput = Input.GetKey(KeyCode.Space);
        jumpInputDown = Input.GetKeyDown(KeyCode.Space);
        jumpInputUp = Input.GetKeyUp(KeyCode.Space);
    }
}
