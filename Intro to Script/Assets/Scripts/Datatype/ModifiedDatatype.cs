using UnityEngine;
using System.Collections;

public class ModifiedDatatype : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Transform trans = transform;
		trans.position = new Vector3 (0, 2, 0);
	}


	// Update is called once per frame
	void Update () 
	{
	}
}