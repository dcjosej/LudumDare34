using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	
	private static GameManager _instance;
	public static GameManager instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = GameObject.FindObjectOfType<GameManager>();
			}
			return _instance;
		}
	}

	public Abomination abomination;


	void Awake()
	{
		abomination = FindObjectOfType<Abomination>();
	}



	public bool debug = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void InstantiatePiece()
	{
		print("Instantiate pieceeeeeee!!! La vihen");
	}
}
