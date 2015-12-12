using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GrowBar : MonoBehaviour {

	private Slider growBar;

	// Use this for initialization
	void Start () {
		growBar = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.debug)
		{
			UpdateKeyboardDebug();
		}
	}

	public void Increase(float amount)
	{
		growBar.value += amount;

		if(growBar.value >= 1)
		{
			GameManager.instance.abomination.CreateRandomPiece();
			growBar.value = 0;
		}
    }

	/*=========== DEBUG =======================*/
	public void UpdateKeyboardDebug()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Increase(0.4f);
		}
	}

}
