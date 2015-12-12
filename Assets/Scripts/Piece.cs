using UnityEngine;
using System.Collections.Generic;

public class Piece : MonoBehaviour {

    public bool isLeaf;
    public Anchor[] anchors = new Anchor[0];
    public Anchor pivot;

    void Reset()
    {
        anchors = GetComponentsInChildren<Anchor>();
    }

    void Awake()
    {
        anchors = GetComponentsInChildren<Anchor>();
    }

	public void Attach(Anchor anchor)
    {

        pivot = anchor;
        transform.SetParent(anchor.transform);
        transform.localPosition = Vector3.zero;
        GameManager.instance.abomination.freeAnchors.Remove(pivot);
        Piece p = anchor.gameObject.GetComponentInParent<Piece>();
        p.isLeaf = false;

        if (anchors.Length > 0)
        {
			GameManager.instance.abomination.freeAnchors.AddRange(anchors);
		}
    }

    public void Detach()
    {
        Piece p = pivot.GetComponentInParent<Piece>();
        p.isLeaf = p.CheckIfIsLeaf();
        //Añadir el anchor pivot a abiertos
        Destroy(gameObject);
    }

    public bool CheckIfIsLeaf()
    {
        foreach (Anchor anchor in anchors)
        {
            if (!anchor.itsFree)
            {
                return false;
            }
        }
        return true;
    }

    void OnDrawGizmosSelected()
    {
        if (anchors != null && anchors.Length > 0)
        {
            for (int i = 0; i < anchors.Length; i++)
            {
                Gizmos.color = Color.yellow;
                Gizmos.DrawSphere(anchors[i].transform.position, 0.2f);
            }
        }

    }


}
