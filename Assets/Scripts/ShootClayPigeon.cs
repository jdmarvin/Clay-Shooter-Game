using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootClayPigeon : MonoBehaviour {

	public float force;

	private Rigidbody rb;


	void Start () {
	
		rb = GetComponent<Rigidbody> ();
	}

	void Update() {

		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100)) {

				rb.AddExplosionForce (force, hit.point, 5, 0, ForceMode.Impulse);
			}
		}
	}


	void OnMouseDown() {
		Debug.Log("You have hit it!");
	}
		
}
