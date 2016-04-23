using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	private int HitPoints = 100;

	// Use this for initialization
	void Start ()
	{
		HitPoints = SubtractedByTen (HitPoints);
		Debug.Log (HitPoints);		
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	int SubtractedByTen (int number)
	{
			int ret;
			ret = number - 10;
			return ret;
	}
}
