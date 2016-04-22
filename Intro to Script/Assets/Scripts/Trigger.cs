using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	void OnTriggerEnter (Collider Box)
	{
		Destroy (gameObject);
		Debug.Log ("Rocket is killed.");
	}
}
