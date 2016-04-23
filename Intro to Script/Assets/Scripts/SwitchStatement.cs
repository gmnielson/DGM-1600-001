using UnityEngine;
using System.Collections;

public class SwitchStatement : MonoBehaviour {

	public int intelligence = 5;

	// Use this for initialization
	void Greet () {
		
		switch (intelligence)
		{
		case 5:
			print ("Hello! Good to see you! Here are cookies!");
			break;

		case 4:
			print ("Welcome back!");
			break;

		case 3:
			print ("Good morning, sir. I am going to teach you the lesson.");
			break;

		case 2:
			print ("Why are you here?");
			break;

		case 1:
			print ("Ugh! Go back where you were!");
			break;

		default:
			print ("Incorrect Intelligence Level");
			break;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
