using System.Collections.Generic;
using UnityEngine;

public class TrackPiece
{
    // Constructors
    public TrackPiece(string id, string name)
    {
        // Constructor
        ID = id;
        Name = name;
        Connections = new List<ConnectionPoint>();
        for (int i = 1; i < Random.Range(1, 4); i++)
        {
            Connections.Add(new ConnectionPoint(
                Quaternion.Euler(0, Random.Range(0, 359), 0),
                new Vector3(Random.Range(0, 10), 0, Random.Range(0, 10))));
        }

    }
    
    // Properties
    public string ID { get; }

    public string Name { get; }
    
    public List<ConnectionPoint> Connections { get; }
}
