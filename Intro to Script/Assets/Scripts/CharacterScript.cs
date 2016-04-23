using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour
{
	public class Stuff
	{
		public int bullets;

		public Stuff(int bul)
		{
			bullets = bul;
		}
	}

	public Stuff myStuff = new Stuff (100);
	public float speed;
	public float turnSpeed;
	public float jumpHeight;
	public Rigidbody bulletPrefab;
	public Transform firePosition;
	public float bulletSpeed;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		Movement ();
		Shoot ();
	}
		
	void Movement ()
	{
		float forwardMovement = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float turnMovement = Input.GetAxis ("Horizontal") * turnSpeed * Time.deltaTime;

		transform.Translate (Vector3.forward * forwardMovement);
		transform.Rotate (Vector3.up * turnMovement);
	}

	void Shoot()
	{
		if (Input.GetButtonDown ("Fire1") && myStuff.bullets > 0) {
			Rigidbody bulletInstance = Instantiate (bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
			bulletInstance.AddForce (firePosition.forward * bulletSpeed);
			myStuff.bullets--;
		}
	}
}
