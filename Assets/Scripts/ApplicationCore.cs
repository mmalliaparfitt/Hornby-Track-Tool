using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationCore : MonoBehaviour
{
    private List<TrackPiece> m_TrackPieces;
    
    // Start is called before the first frame update
    private void Start()
    {
        m_TrackPieces = new List<TrackPiece>();
        m_TrackPieces.Add(new TrackPiece("R8206", "Power Track"));
        m_TrackPieces.Add(new TrackPiece("R600", "Straight Track"));
        m_TrackPieces.Add(new TrackPiece("R601", "Double Straight"));
        m_TrackPieces.Add(new TrackPiece("R603", "Long Straight"));
        m_TrackPieces.Add(new TrackPiece("R606", "Curve - Second Radius"));
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var trackPiece in m_TrackPieces)
            {
                Debug.Log("Track: " + trackPiece.ID + " called: "+ trackPiece.Name + " with these connections: ");
                foreach (var connection in trackPiece.Connections)
                {
                    Debug.Log(connection.Position + " " + connection.Rotation);
                }
            }
        }
    }
}
