using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {

		string[] strings = new string[4];

		strings[0] = "Male #1: Come on!";
		strings[1] = "Male #2: I can't. It is too hard to climb to the top of the cube.";
		strings[2] = "Female #1: Just do it!";
		strings [3] = "Male #2: Ugh!";

		foreach(string item in strings)
		{
			print (item);
		}


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
