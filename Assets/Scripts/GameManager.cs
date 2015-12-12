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

    public GameObject abominationPrefab;
    
	public Abomination abomination { get; set; }


	public bool debug = true;

    void Start()
    {
        InstantiateAbomination();
    }


	public void InstantiateAbomination()
	{
        abomination = (Instantiate(abominationPrefab) as GameObject).GetComponent<Abomination>();
	}
}
