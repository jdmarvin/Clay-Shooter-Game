using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchClayPigeon : MonoBehaviour {


	public float clayPigeonThrust;
	public float clayPigeonTorque;

	private Rigidbody clayPigeonRigidbody;


	void Awake () {
		clayPigeonRigidbody = GetComponent<Rigidbody> ();
	}

	void Start () {
		clayPigeonRigidbody.AddForce (transform.forward * clayPigeonThrust, ForceMode.Impulse);
		clayPigeonRigidbody.AddTorque (transform.up * clayPigeonTorque);
		clayPigeonRigidbody.useGravity = true;
		
	}


}
