using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject clayPigeon;
	public Transform shootTable;

	void Update () {
		if (Input.GetKeyDown("space")) {
			Instantiate (clayPigeon, shootTable.position, shootTable.rotation);
		}
	}
}
