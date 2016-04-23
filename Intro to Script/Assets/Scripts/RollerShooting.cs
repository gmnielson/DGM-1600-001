using UnityEngine;
using System.Collections;

public class RollerShooting : MonoBehaviour {

	public Rigidbody bulletPrefab;
	public Transform firePosition;
	public float bulletSpeed;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("SpawnObject", 3, 5);
	}
	
	// Update is called once per frame
	void SpawnObject ()
	{
		Rigidbody bulletInstance = Instantiate (bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
		bulletInstance.AddForce (firePosition.forward * bulletSpeed);
	}
}
