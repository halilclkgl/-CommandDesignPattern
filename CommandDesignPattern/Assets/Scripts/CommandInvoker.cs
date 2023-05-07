using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker 
{
    private Stack<ICommand> commandStack;

    public CommandInvoker()
    {
        commandStack = new Stack<ICommand>();
    }

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        commandStack.Push(command);
    }

    public void UndoLastCommand()
    {
        if (commandStack.Count > 0)
        {
            ICommand lastCommand = commandStack.Pop();
            lastCommand.Undo();
        }
    }
}
