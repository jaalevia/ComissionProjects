using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    private const int CAPACITY = 10;

    private List<ICommand> _commandQueue;

    private ICommand _rightClickCMD;
    private ICommand _leftClickCMD;

    public CommandInvoker(Transform player)
    {
        _rightClickCMD = new RightClickCMD(player);
        _leftClickCMD = new LeftClickCMD(player);

        _commandQueue = new List<ICommand>();
    }

    public void Execute(ButtonType buttonType, Vector2 position)
    {
        if (buttonType == ButtonType.LeftClickCMD)
        {
            _leftClickCMD.Invoke(position);
            _commandQueue.Add(_leftClickCMD);
        }
        else if (buttonType == ButtonType.RightClickCMD)
        {
            _rightClickCMD.Invoke(position);
            _commandQueue.Add(_rightClickCMD);
        }

        if (_commandQueue.Count > CAPACITY)
        {
            _commandQueue.RemoveAt(0);
        }
    }

    public void ExecuteRightClickCommands()
    {
        RightClickCMD right = (RightClickCMD)_rightClickCMD;
        right.Execute();
    }
    
    public void Undo() 
    {
        if (_commandQueue.Count > 0)
        {
            _commandQueue[_commandQueue.Count - 1].Undo();
            _commandQueue.RemoveAt(_commandQueue.Count - 1);
        }
    }
}
