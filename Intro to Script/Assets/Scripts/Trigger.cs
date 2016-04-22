using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	void OnTriggerEnter (Collider Box)
	{
		Debug.Log ("Death");
	}
}
