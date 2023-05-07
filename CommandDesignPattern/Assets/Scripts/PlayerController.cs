using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRB;
    private CommandInvoker commandInvoker;

    private void Awake()
    {
        commandInvoker = new CommandInvoker();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // JumpCommand'ý oluþtur ve yürüt
            ICommand jumpCommand = new JumpCommand(playerRB, 5f);
            commandInvoker.ExecuteCommand(jumpCommand);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Son komutu geri al
            commandInvoker.UndoLastCommand();
        }
    }
}



