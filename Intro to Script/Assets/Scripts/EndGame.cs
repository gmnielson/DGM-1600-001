using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	public GameObject other;


	void OnTriggerEnter (Collider Box)
	{
		if (Box.transform.tag == "Player")
		{
			Destroy (other);
			Debug.Log ("You won!");
		}
	}
}