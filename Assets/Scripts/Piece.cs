using UnityEngine;
using System.Collections.Generic;

public class Piece : MonoBehaviour {

    public bool isLeaf;
    public Transform[] anchors = new Transform[0];
    public Transform pivot;

    void Reset()
    {
        anchors = FindAnchors();
    }

    void Awake()
    {
        anchors = FindAnchors();
    }

	public void Attach(Transform t)
    {

        pivot = t;
        transform.SetParent(t);
        transform.localPosition = Vector3.zero;

        Piece p = t.gameObject.GetComponentInParent<Piece>();
        p.isLeaf = false;

        if (anchors.Length > 0)
        {
            //Añadir nuevos anchors a abiertos
        }
    }

    public void Detach()
    {
        Piece p = pivot.GetComponentInParent<Piece>();
        //Añadir pivot
        p.isLeaf = p.CheckIfIsLeaf();
        Destroy(this.gameObject);
    }

    public bool CheckIfIsLeaf()
    {
        //Usar cuando se detache
        return false;
    }

    Transform[] FindAnchors()
    {
        List<Transform> anchors = new List<Transform>();
        foreach (Transform t in this.transform)
        {
            if (t.tag == "Anchor")
            {
                anchors.Add(t);
            }
        }
        return anchors.ToArray();
    }

    void OnDrawGizmosSelected()
    {
        if (anchors.Length > 0)
        {
            for (int i = 0; i < anchors.Length; i++)
            {
                Gizmos.color = Color.yellow;
                Gizmos.DrawSphere(anchors[i].transform.position, 0.2f);
            }
        }

    }


}
