using UnityEngine;
using System.Collections;

public class EndGame2 : MonoBehaviour {

	public GameObject other;


	void OnTriggerEnter (Collider Box)
	{
		if (Box.transform.tag == "Player")
		{
			Destroy (other);
			Debug.Log ("Roller is defeated.");
			Debug.Log ("You won!");
		}
	}
}
