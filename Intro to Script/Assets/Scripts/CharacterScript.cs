using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour
{
	public class Stuff
	{
		public int bullets;
		public int grenades;
		public int rockets;

		public Stuff(int bul, int gre, int roc)
		{
			bullets = bul;
			grenades = gre;
			rockets = roc;
		}
	}

	public Stuff myStuff = new Stuff (10, 3, 4);
	public float speed;
	public float turnSpeed;
	public float runSpeed;
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
		float jumpUp = Input.GetAxis ("Jump") * jumpHeight * Time.deltaTime;

		transform.Translate (Vector3.forward * forwardMovement);
		transform.Rotate (Vector3.up * turnMovement);
		transform.Translate (Vector3.up * jumpUp);
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
