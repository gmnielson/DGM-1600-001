using UnityEngine;
using System.Collections;

public class LookAt1 : MonoBehaviour
{
	public Transform target;

	void Update ()
	{
		transform.LookAt(target);
	}
}