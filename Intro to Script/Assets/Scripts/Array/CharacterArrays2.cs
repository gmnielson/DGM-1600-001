using UnityEngine;
using System.Collections;

public class CharacterArrays2 : MonoBehaviour {

	public GameObject[] players;

	// Use this for initialization
	void Start ()
	{
		players = GameObject.FindGameObjectsWithTag("Player");

		for (int i = 0; i < players.Length; i++) 
		{
			Debug.Log ("Player number "+i+" name is "+players[i].name);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
