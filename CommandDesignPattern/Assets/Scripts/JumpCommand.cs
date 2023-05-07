using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : ICommand

{
    private Rigidbody rb;
    private float jumpForce;

    public JumpCommand(Rigidbody rb, float jumpForce)
    {
        this.rb = rb;
        this.jumpForce = jumpForce;
    }

    public void Execute()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void Undo()
    {
        rb.AddForce(Vector3.down * jumpForce, ForceMode.Impulse);
    }
}
