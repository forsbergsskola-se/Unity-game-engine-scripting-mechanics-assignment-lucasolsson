using System;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float walkInput;
    public bool jumpInput;
    public bool jumpInputDown;
    public bool jumpInputUp;
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
