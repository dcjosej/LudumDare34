using UnityEngine;
using System.Collections;

public class Anchor : MonoBehaviour {

    public Piece attached;

    public bool itsFree
    {
        get { return !attached; }
    }


}
