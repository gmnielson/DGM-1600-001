﻿using UnityEngine;
using System.Collections;

public class BasicCharacterScript : MonoBehaviour
{
	Animator anim;
	int jumpHash = Animator.StringToHash ("Jump");
	int runRush = Animator.StringToHash ("Sprint");

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float move = Input.GetAxis ("Vertical");
		anim.SetFloat ("Walk", move);

		if (Input.GetKeyDown (KeyCode.LeftShift))
		{
			anim.SetFloat (runRush);
		}

		if (Input.GetKeyDown (KeyCode.Space))
		{
			anim.SetTrigger (jumpHash);
		}
	}
}