using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Hit) 
	{
		if (Hit.transform.tag == "Roller") 
		{
			//Destroy (gameObject);
			Debug.Log ("Death");
		}
	}
}
