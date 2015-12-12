using UnityEngine;
using System.Collections;

public class AnchorViewer : MonoBehaviour {

    Anchor[] anchors;

    void OnEnable()
    {
        anchors = transform.GetComponentsInChildren<Anchor>();
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
