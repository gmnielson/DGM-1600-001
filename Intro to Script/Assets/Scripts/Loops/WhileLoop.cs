using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

	int cupsInTheSink = 4;

	// Use this for initialization
	void Start () 
	{

		while (cupsInTheSink > 0)
		{
			Debug.Log ("I am washing a cup!");
			cupsInTheSink--;
		}
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
