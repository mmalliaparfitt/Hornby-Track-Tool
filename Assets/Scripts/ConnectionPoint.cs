using System;
using UnityEngine;

public class ConnectionPoint
{
    // Constructors
    public ConnectionPoint(Quaternion rotation, Vector3 position)
    {
        Rotation = rotation;
        Position = position;
    }
    
    // Properties
    public Quaternion Rotation { get; }
    public Vector3 Position { get; }
}
