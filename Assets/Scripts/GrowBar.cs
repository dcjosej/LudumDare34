using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GrowBar : MonoBehaviour {

	private Slider growBar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Increase(int amount)
	{
		growBar.value += amount;

		if(growBar.value >= 1)
		{
			GameManager.instance.InstantiatePiece();
		}
    }

}
