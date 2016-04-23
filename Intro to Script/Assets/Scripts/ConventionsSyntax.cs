using UnityEngine;
using System.Collections;

public class ConventionsSyntax : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Debug.Log (transform.position.y);

		if (transform.position.y <= 10f) {
			Debug.Log ("Ahhhhh! I am falling!");
		}

		if (transform.position.y <= 6f) {
			Debug.Log ("Bye, cruel world!");
		}

		if (transform.position.y <= 3f) {
			Debug.Log ("I am about to hit the ground.");
		}

		if (transform.position.y <= -4f) {
			Debug.Log ("Hmm? I am not dead yet.");
		}

		if (transform.position.y <= -7f) {
			Debug.Log ("Wait...");
		}

		if (transform.position.y <= -11f) {
			Debug.Log ("Oh, no! I am going to heck! Ahhhhhhh!!!!! HEEEEELLLLLLP!!!!!!!");
		}

	}

	// Update is called once per frame
	void Update () {

	}
}