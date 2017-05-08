using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootClayPigeon : MonoBehaviour {

	public GameObject clayPigeonExplosion;


	void OnMouseDown() {
		
		Destroy (gameObject);
		Instantiate (clayPigeonExplosion, transform.position, transform.rotation);
		Debug.Log("You have hit it!");
	}
		
}
