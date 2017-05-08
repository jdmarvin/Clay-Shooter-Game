using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject clayPigeon;
	public Transform shootTable;

	public float waveStart;
	public float waveDelay;

	public bool clayWave;

		
	void Update () {
		if (Input.GetKeyDown("space")) {
			Instantiate (clayPigeon, shootTable.position, shootTable.rotation);
		}
	}

	void StartClayWave () {

		if (clayWave) {

			StartCoroutine (ClayWaves ());
		}
	}

	IEnumerator ClayWaves () {

		yield return new WaitForSeconds (waveStart);
		while (true) {

			Instantiate (clayPigeon, shootTable.position, shootTable.rotation);
			yield return new WaitForSeconds (waveDelay);
		}

	}
}
