﻿using UnityEngine;
using System.Collections;

public class Multiply : MonoBehaviour
{
	public int myInt = 10;

	// Use this for initialization
	void Start ()
	{
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	}

	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
