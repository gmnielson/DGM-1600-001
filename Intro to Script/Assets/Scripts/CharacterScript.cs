using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponents<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", move);
	}
}
