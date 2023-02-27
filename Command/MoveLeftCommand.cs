using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    private Transform _player;

    public MoveLeftCommand(Transform player)
    {
        _player = player;
    }
    public void Execute()
    {
        _player.position += Vector3.left;
    }

    public void Undo()
    {
        _player.position -= Vector3.left;
    }
}
