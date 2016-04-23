using UnityEngine;
using System.Collections;

public class TranslateRotation : MonoBehaviour {

	public float moveSpeed = 10f;
	public Transform target;

	
	// Update is called once per frame
	void Update ()
	{
		transform.LookAt (target);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}
}
