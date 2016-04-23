using UnityEngine;
using System.Collections;

public class RollerAttitude : MonoBehaviour {

	void OnTriggerEnter (Collider Box)
	{
		if(Box.transform.tag == "Bullet")
		{
			Debug.Log ("Roller can't take damage.");
		}
	}
}
