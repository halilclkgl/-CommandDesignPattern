using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeController : MonoBehaviour
{
    public GameObject cubeObject;
    public List<Material> colorMaterials;

    private CommandInvoker commandInvoker;

    private void Awake()
    {
        commandInvoker = new CommandInvoker();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ICommand colorChangeCommand = new ColorChangeCommand(cubeObject, colorMaterials);
            commandInvoker.ExecuteCommand(colorChangeCommand);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            commandInvoker.UndoLastCommand();
        }
    }
}

