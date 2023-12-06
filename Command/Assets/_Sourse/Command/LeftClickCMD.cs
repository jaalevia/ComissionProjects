using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftClickCMD : ICommand
{
    private List<Vector3> _positions = new List<Vector3>();
    private Transform _player;

    public LeftClickCMD(Transform player)
    { 
        _player = player;
    }
    public void Invoke(Vector3 position)
    {
        _positions.Add(_player.position);
        _player.position = position;
    }

    public void Undo()
    {
        if (_positions.Count > 0)
        {
            _player.position = _positions[_positions.Count - 1];
            _positions.RemoveAt(_positions.Count - 1);
        }
    }
}
