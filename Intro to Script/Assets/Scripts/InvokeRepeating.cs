﻿using UnityEngine;
using System.Collections;

public class InvokeRepeating : MonoBehaviour
{
	public GameObject target;

	// Use this for initialization
	void Start ()
	{
		InvokeRepeating ("SpawnObject", 1, 1);
	}

	void SpawnObject ()
	{
		float x = Random.Range (-0.5f, 0.5f);
		float z = Random.Range (-0.5f, 0.5f);
		Instantiate (target, new Vector3 (x, .05f, z), Quaternion.identity);
	}
}
