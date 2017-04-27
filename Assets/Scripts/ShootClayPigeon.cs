using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootClayPigeon : MonoBehaviour {


	public float clayPigeonThrust;

	private Rigidbody clayPigeonRigidbody;


	void Awake () {
		clayPigeonRigidbody = GetComponent<Rigidbody> ();
	}

	void Start () {
		clayPigeonRigidbody.AddForce (transform.forward * clayPigeonThrust);
		clayPigeonRigidbody.useGravity = true;

		//Vector3 direction = clayPigeon.transform.position - new Vector3 (transform.position.x * transform.localScale.x, transform.position.y, transform.position.z);
		//clayPigeonRigidbody.AddForceAtPosition(direction.normalized, new Vector3 (10f,2f,10f));
	}


}
