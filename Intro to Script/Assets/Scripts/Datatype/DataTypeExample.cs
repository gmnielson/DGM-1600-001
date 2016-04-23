using UnityEngine;
using System.Collections;

public class DataTypeExample : MonoBehaviour
{

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			MoveUp ();

		if(Input.GetKeyDown (KeyCode.RightAlt))
			MoveDown ();
	}


	void MoveUp ()
	{ //when space key is pressed the following happens.
		Transform tran = transform;
		tran.position = new Vector3(0, 5, 0);

		Debug.Log ("Moved Up");
	}

	void MoveDown ()
	{ //when right alt key is pressed the following happens.
		Transform tran = transform;
		tran.position = new Vector3 (0, 2, 0);

		Debug.Log ("Moved Down");
	}
}