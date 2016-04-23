using UnityEngine;
using System.Collections;

public class RollerScript : MonoBehaviour
{
	public Transform target;
	public float moveSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}
}
