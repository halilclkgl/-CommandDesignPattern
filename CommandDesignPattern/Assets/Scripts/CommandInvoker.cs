using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker 
{
    private Stack<ICommand> undoStack;

    public CommandInvoker()
    {
        undoStack = new Stack<ICommand>();
    }

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        undoStack.Push(command);
    }

    public void UndoLastCommand()
    {
        if (undoStack.Count > 0)
        {
            ICommand lastCommand = undoStack.Pop();
            lastCommand.Undo();
        }
    }
}
