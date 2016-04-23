using UnityEngine;
using System.Collections;

public class Invoke : MonoBehaviour
{
	public GameObject target;

	// Use this for initialization
	void Start ()
	{
		Invoke ("SpawnObject", 90);
	}

	void SpawnObject ()
	{
		float x = Random.Range (-0.01f, 0.01f);
		float z = Random.Range (-0.01f, 0.01f);
		Instantiate (target, new Vector3 (x, 0, z), Quaternion.identity);
	}
}
