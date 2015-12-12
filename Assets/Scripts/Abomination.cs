using UnityEngine;
using System.Collections.Generic;

public class Abomination : MonoBehaviour {

    List<Anchor> freeAnchors;
    Piece basePiece;
    
    void Awake()
    {
        freeAnchors = new List<Anchor>(basePiece.anchors);
    }

    public void CreateRandomPiece()
    {
        Anchor selectedAnchor = freeAnchors[Random.Range(0, freeAnchors.Count)];
        Piece newPiece = (Instantiate(null, selectedAnchor.transform.position, Quaternion.identity) as GameObject).GetComponent<Piece>();
        newPiece.transform.SetParent(selectedAnchor.transform);
        newPiece.Attach(selectedAnchor);
    }
}
