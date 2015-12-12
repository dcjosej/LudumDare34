using UnityEngine;
using System.Collections.Generic;

public class Abomination : MonoBehaviour {

    public List<Anchor> freeAnchors;
    public Piece basePiece;
    public GameObject[] availablePieces;

    void Awake()
    {
        freeAnchors = new List<Anchor>(basePiece.anchors);
        GameManager.instance.abomination = this;
    }

    [ContextMenu("Create Piece")]
    public void CreateRandomPiece()
    {
        Anchor selectedAnchor = freeAnchors[Random.Range(0, freeAnchors.Count)];
        Piece newPiece = (Instantiate(GetRandomPiece(), selectedAnchor.transform.position, Quaternion.identity) as GameObject).GetComponent<Piece>();
        newPiece.transform.SetParent(selectedAnchor.transform);
        newPiece.Attach(selectedAnchor);
    }

    GameObject GetRandomPiece()
    {
        return availablePieces[Random.Range(0, availablePieces.Length)];
    }
}
