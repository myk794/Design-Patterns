using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Stack<ICommand> _commands;
    [SerializeField] private Transform player;
    private void Start()
    {
        _commands = new Stack<ICommand>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ICommand command = new MoveRightCommand(player);
            _commands.Push(command);
            command.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ICommand command = new MoveLeftCommand(player);
            _commands.Push(command);
            command.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            if(_commands.Count > 0)
                _commands.Pop().Undo();
        }
    }
}
