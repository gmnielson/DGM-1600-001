using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	int numEnemies = 3;

	// Use this for initialization
	void Start () {

		for (int countEnemies = 8; countEnemies > numEnemies; countEnemies--)
		{
			Debug.Log ("Creating enemy number: " + countEnemies);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
