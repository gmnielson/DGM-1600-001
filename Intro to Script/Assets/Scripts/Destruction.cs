﻿using UnityEngine;
using System.Collections;

public class Destruction : MonoBehaviour
{

	void OnTriggerEnter (Collider Box)
	{
		if(Box.transform.tag == "Bullet")
		{
			Destroy(gameObject);
			print ("You destroyed " + gameObject.name);
		}
	}
}