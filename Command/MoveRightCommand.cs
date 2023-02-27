using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{
    private Transform _player;

    public MoveRightCommand(Transform player)
    {
        _player = player;
    }
    public void Execute()
    {
        _player.position += Vector3.right;
    }

    public void Undo()
    {
        _player.position -= Vector3.right;
    }
}
