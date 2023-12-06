using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class RightClickCMD : ICommand
{
    private List<Vector3> _positions = new List<Vector3>();
    private Transform _player;
    private int _drawbackCounter = 0;

    public RightClickCMD(Transform player) 
    {
        _player = player;
    }
    public void Invoke(Vector3 position)
    {
        _positions.Add(position);
        _drawbackCounter++;
    }

    public void Execute() 
    {
        for (int i = 0; i < _positions.Count; i++)
        {
            _player.transform.position = _positions[i];
        }
    }

    public void Undo()
    {
        if (_positions.Count > 0)
        {
            _player.transform.position = _positions[_drawbackCounter - 1];
            _drawbackCounter--;
            _positions.RemoveAt(_positions.Count - 1);
        }
    }
}
