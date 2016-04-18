using UnityEngine;
using System.Collections;

public class Destruction : MonoBehaviour
{
	public GameObject target;

	void Update ()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			Destroy(target);
		}
	}
}