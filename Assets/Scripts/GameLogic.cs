using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject clayPigeon;
	public Transform shootTable;

	public float waveStart;
	public float waveDelay;

	public bool clayWave;

	public float launchTableAngle;

	private float randomAngle;

		
	void Update () {
		if (Input.GetKeyDown("space")) {
			randomShotAngle ();
			shootTable.transform.eulerAngles = new Vector3 (launchTableAngle,
				randomAngle,
				shootTable.transform.rotation.z);
			Instantiate (clayPigeon, shootTable.position, shootTable.rotation);
		}

		if (Input.GetKeyDown("return")) {
			clayWave = true;
			StartClayWave ();
		}

		if (Input.GetKeyDown("delete")) {
			clayWave = false;
			Debug.Log ("Stop the wave!");
		}
	}

	void StartClayWave () {

		if (clayWave) {

			StartCoroutine (ClayWaves ());
		}
	}

	IEnumerator ClayWaves () {

		yield return new WaitForSeconds (waveStart);
		while (clayWave) {

			Instantiate (clayPigeon, shootTable.position, shootTable.rotation);
			yield return new WaitForSeconds (waveDelay);
		}

	}

	void randomShotAngle () {
		randomAngle = Random.Range (45.0f, -45.0f);
	}
}
