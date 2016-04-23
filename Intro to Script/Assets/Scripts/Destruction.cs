using UnityEngine;
using System.Collections;

public class Destruction : MonoBehaviour
{

	void OnTriggerEnter (Collider Box)
	{
		if(Box.transform.tag == "Bullet")
		{
			Destroy(gameObject);
			Debug.Log ("This game object is destroyed by the bullet.");
		}
	}
}